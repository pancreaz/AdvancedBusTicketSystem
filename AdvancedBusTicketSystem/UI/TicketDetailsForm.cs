using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Text;
using System.Windows.Forms;

namespace AdvancedBusTicketSystem.UI
{
    public partial class TicketDetailsForm : Form
    {
        private readonly Ticket _ticket;

        public TicketDetailsForm(Ticket ticket)
        {
            InitializeComponent();
            _ticket = ticket;

            RenderTicketReceipt();
        }

        private void RenderTicketReceipt()
        {
            if (_ticket == null) return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==========================================");
            sb.AppendLine("        ADVANCED BUS TICKET SYSTEM        ");
            sb.AppendLine("       OFFICIAL TRAVEL VOUCHER RECEIPT    ");
            sb.AppendLine("==========================================");
            sb.AppendLine($"PNR CODE      : {_ticket.PnrCode}");
            sb.AppendLine($"BOOKING DATE  : {_ticket.BookingDate:yyyy-MM-dd HH:mm}");
            sb.AppendLine($"STATUS        : {_ticket.Status}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine("PASSENGER DETAILS:");
            sb.AppendLine($"  Name        : {_ticket.Customer?.FullName}");
            sb.AppendLine($"  Gender      : {_ticket.Customer?.Gender}");
            sb.AppendLine($"  Phone       : {_ticket.Customer?.PhoneNumber}");
            sb.AppendLine($"  ID/Passport : {_ticket.Customer?.IdentityNumber}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine("TRIP DETAILS:");
            sb.AppendLine($"  Bus Operator: {_ticket.Trip?.Bus?.OperatorName}");
            sb.AppendLine($"  Plate       : {_ticket.Trip?.Bus?.LicensePlate}");
            sb.AppendLine($"  Bus Layout  : {_ticket.Trip?.Bus?.LayoutType}");
            sb.AppendLine($"  Route       : {_ticket.Trip?.Route?.Origin} -> {_ticket.Trip?.Route?.Destination}");
            sb.AppendLine($"  Departure   : {_ticket.Trip?.DepartureDate:yyyy-MM-dd} at {_ticket.Trip?.DepartureTime:hh\\:mm}");
            sb.AppendLine($"  ASSIGNED SEAT #: {_ticket.SeatNumber}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine($"FARE PAID     : ${_ticket.PricePaid:F2}");
            sb.AppendLine("==========================================");
            sb.AppendLine("    Thank you for traveling with us!     ");
            sb.AppendLine("==========================================");

            rtbReceipt.Text = sb.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ticket receipt for PNR {_ticket?.PnrCode} copied to clipboard and ready for printing!", "Print Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(rtbReceipt.Text);
        }
    }
}
