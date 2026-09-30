using AdvancedBusTicketSystem.Data.Persistence;
using AdvancedBusTicketSystem.Domain.Entities;
using AdvancedBusTicketSystem.Domain.Enums;
using AdvancedBusTicketSystem.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdvancedBusTicketSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly TripService _tripService;
        private readonly TicketService _ticketService;
        private readonly RevenueService _revenueService;

        private Trip _currentSelectedTrip;
        private int _currentSelectedSeatNumber = -1;

        public MainForm()
        {
            InitializeComponent();

            _tripService = new TripService();
            _ticketService = new TicketService();
            _revenueService = new RevenueService();

            seatMapControl.SeatClicked += OnSeatClickedOnMap;

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateRouteDropdowns();
            dtpTripDate.Value = DateTime.Today;

            LoadAllTrips();
            RefreshTicketGrid();
            RefreshAnalytics();
            RefreshScheduleGrid();
        }

        private void PopulateRouteDropdowns()
        {
            var routes = AppDbContext.Instance.Routes;

            var origins = routes.Select(r => r.Origin).Distinct().OrderBy(o => o).ToList();
            origins.Insert(0, "-- All Origins --");
            cmbOrigin.DataSource = origins;

            var destinations = routes.Select(r => r.Destination).Distinct().OrderBy(d => d).ToList();
            destinations.Insert(0, "-- All Destinations --");
            cmbDestination.DataSource = destinations;
        }

        private void LoadAllTrips()
        {
            var trips = _tripService.GetAllTrips().ToList();
            lstTrips.DataSource = trips;

            if (trips.Count > 0)
            {
                lstTrips.SelectedIndex = 0;
            }
        }

        private void btnSearchTrips_Click(object sender, EventArgs e)
        {
            string origin = cmbOrigin.SelectedIndex > 0 ? cmbOrigin.SelectedItem.ToString() : null;
            string dest = cmbDestination.SelectedIndex > 0 ? cmbDestination.SelectedItem.ToString() : null;
            DateTime date = dtpTripDate.Value;

            var filteredTrips = _tripService.SearchTrips(origin, dest, date).ToList();
            lstTrips.DataSource = filteredTrips;

            if (filteredTrips.Count == 0)
            {
                MessageBox.Show("No trips found matching the selected route criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _currentSelectedTrip = null;
                seatMapControl.Controls.Clear();
                lblSelectedTripInfo.Text = "No trip selected.";
                ResetBookingSelection();
            }
        }

        private void lstTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentSelectedTrip = lstTrips.SelectedItem as Trip;
            ResetBookingSelection();

            if (_currentSelectedTrip != null && _currentSelectedTrip.Bus != null)
            {
                lblSelectedTripInfo.Text = $"{_currentSelectedTrip.Bus.OperatorName} ({_currentSelectedTrip.Bus.LayoutType})\n" +
                                           $"{_currentSelectedTrip.Route?.Origin} -> {_currentSelectedTrip.Route?.Destination}\n" +
                                           $"Date: {_currentSelectedTrip.DepartureDate:yyyy-MM-dd} {_currentSelectedTrip.DepartureTime:hh\\:mm} | Fare: ${_currentSelectedTrip.TicketPrice:F2}";

                var occupancy = _tripService.GetSeatOccupancyForTrip(_currentSelectedTrip.Id);
                seatMapControl.LoadSeatMap(_currentSelectedTrip.Bus.LayoutType, _currentSelectedTrip.Bus.Capacity, occupancy);
            }
        }

        private void OnSeatClickedOnMap(int seatNumber, SeatStatus previousStatus)
        {
            if (_currentSelectedTrip == null) return;

            if (seatMapControl.SelectedSeatNumber > 0)
            {
                _currentSelectedSeatNumber = seatMapControl.SelectedSeatNumber;
                lblSelectedSeatNum.Text = $"Selected Seat: #{_currentSelectedSeatNumber}";
                lblTotalFare.Text = $"Total Fare: ${_currentSelectedTrip.TicketPrice:F2}";
                btnProceedCheckout.Enabled = true;
            }
            else
            {
                ResetBookingSelection();
            }
        }

        private void ResetBookingSelection()
        {
            _currentSelectedSeatNumber = -1;
            lblSelectedSeatNum.Text = "Selected Seat: None";
            lblTotalFare.Text = "Total Fare: $0.00";
            btnProceedCheckout.Enabled = false;
        }

        private void btnProceedCheckout_Click(object sender, EventArgs e)
        {
            if (_currentSelectedTrip == null || _currentSelectedSeatNumber <= 0)
            {
                MessageBox.Show("Please select a trip and an available seat first.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (BookingModalForm modal = new BookingModalForm(_currentSelectedTrip, _currentSelectedSeatNumber))
            {
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    Customer passenger = modal.Passenger;
                    Ticket ticket = _ticketService.IssueTicket(_currentSelectedTrip.Id, passenger, _currentSelectedSeatNumber, out string errorMsg);

                    if (ticket != null)
                    {
                        MessageBox.Show($"Reservation Confirmed!\nPNR Code: {ticket.PnrCode}\nSeat #{ticket.SeatNumber} reserved for {passenger.FullName}.", 
                                        "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload seat map occupancy
                        var occupancy = _tripService.GetSeatOccupancyForTrip(_currentSelectedTrip.Id);
                        seatMapControl.LoadSeatMap(_currentSelectedTrip.Bus.LayoutType, _currentSelectedTrip.Bus.Capacity, occupancy);
                        ResetBookingSelection();

                        // Refresh other tabs
                        RefreshTicketGrid();
                        RefreshAnalytics();

                        // Show receipt form
                        using (TicketDetailsForm details = new TicketDetailsForm(ticket))
                        {
                            details.ShowDialog(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Booking Failed: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // --- Tab 2: Ticket Manager ---

        private void RefreshTicketGrid(IEnumerable<Ticket> ticketList = null)
        {
            var tickets = ticketList ?? _ticketService.GetAllTickets();

            var gridData = tickets.Select(t => new
            {
                PNR = t.PnrCode,
                Passenger = t.Customer?.FullName,
                Phone = t.Customer?.PhoneNumber,
                Gender = t.Customer?.Gender.ToString(),
                Route = t.Trip?.Route != null ? $"{t.Trip.Route.Origin} -> {t.Trip.Route.Destination}" : "N/A",
                Date = t.Trip?.DepartureDate.ToString("yyyy-MM-dd"),
                Time = t.Trip?.DepartureTime.ToString(@"hh\:mm"),
                Seat = t.SeatNumber,
                Price = $"${t.PricePaid:F2}",
                Status = t.Status.ToString(),
                BookedAt = t.BookingDate.ToString("yyyy-MM-dd HH:mm")
            }).ToList();

            dgvTickets.DataSource = gridData;
        }

        private void btnSearchPnr_Click(object sender, EventArgs e)
        {
            string pnr = txtSearchPnr.Text.Trim();
            if (string.IsNullOrEmpty(pnr))
            {
                RefreshTicketGrid();
                return;
            }

            var ticket = _ticketService.GetTicketByPnr(pnr);
            if (ticket != null)
            {
                RefreshTicketGrid(new[] { ticket });
            }
            else
            {
                MessageBox.Show($"No ticket found matching PNR: {pnr}", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshTickets_Click(object sender, EventArgs e)
        {
            txtSearchPnr.Clear();
            RefreshTicketGrid();
        }

        private string GetSelectedGridPnr()
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                return dgvTickets.SelectedRows[0].Cells["PNR"].Value?.ToString();
            }
            return null;
        }

        private void btnViewVoucher_Click(object sender, EventArgs e)
        {
            string pnr = GetSelectedGridPnr();
            if (string.IsNullOrEmpty(pnr))
            {
                MessageBox.Show("Please select a ticket row from the grid first.", "Select Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ticket ticket = _ticketService.GetTicketByPnr(pnr);
            if (ticket != null)
            {
                using (TicketDetailsForm details = new TicketDetailsForm(ticket))
                {
                    details.ShowDialog(this);
                }
            }
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            string pnr = GetSelectedGridPnr();
            if (string.IsNullOrEmpty(pnr))
            {
                MessageBox.Show("Please select a ticket row from the grid to cancel.", "Select Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to cancel ticket PNR {pnr}?", "Confirm Cancellation", 
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (_ticketService.CancelTicket(pnr, out string msg))
                {
                    MessageBox.Show(msg, "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTicketGrid();
                    RefreshAnalytics();

                    if (_currentSelectedTrip != null)
                    {
                        var occupancy = _tripService.GetSeatOccupancyForTrip(_currentSelectedTrip.Id);
                        seatMapControl.LoadSeatMap(_currentSelectedTrip.Bus.LayoutType, _currentSelectedTrip.Bus.Capacity, occupancy);
                    }
                }
                else
                {
                    MessageBox.Show(msg, "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Tab 3: Analytics ---

        private void RefreshAnalytics()
        {
            lblRevenueValue.Text = $"${_revenueService.GetTotalRevenue():N2}";
            lblBookingsValue.Text = _revenueService.GetConfirmedTicketCount().ToString();
            lblTripsValue.Text = _revenueService.GetActiveTripCount().ToString();
            lblOccupancyValue.Text = $"{_revenueService.GetOverallOccupancyRatePercentage():F1}%";
        }

        private void btnRefreshAnalytics_Click(object sender, EventArgs e)
        {
            RefreshAnalytics();
        }

        // --- Tab 4: Schedule Overview ---

        private void RefreshScheduleGrid()
        {
            var trips = _tripService.GetAllTrips();
            var scheduleData = trips.Select(t => new
            {
                Operator = t.Bus?.OperatorName,
                Plate = t.Bus?.LicensePlate,
                Layout = t.Bus?.LayoutType.ToString(),
                Capacity = t.Bus?.Capacity,
                Origin = t.Route?.Origin,
                Destination = t.Route?.Destination,
                Distance = $"{t.Route?.DistanceKm} km",
                Date = t.DepartureDate.ToString("yyyy-MM-dd"),
                DepartureTime = t.DepartureTime.ToString(@"hh\:mm"),
                TicketPrice = $"${t.TicketPrice:F2}"
            }).ToList();

            dgvTripsSchedule.DataSource = scheduleData;
        }
    }
}
