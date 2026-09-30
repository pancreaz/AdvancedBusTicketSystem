using AdvancedBusTicketSystem.Domain.Entities;
using AdvancedBusTicketSystem.Domain.Enums;
using System;
using System.Windows.Forms;

namespace AdvancedBusTicketSystem.UI
{
    public partial class BookingModalForm : Form
    {
        public Customer Passenger { get; private set; }

        public BookingModalForm(Trip trip, int seatNumber)
        {
            InitializeComponent();

            if (trip != null)
            {
                lblSummary.Text = $"Trip: {trip.Route?.Origin} -> {trip.Route?.Destination} | Date: {trip.DepartureDate:yyyy-MM-dd} {trip.DepartureTime:hh\\:mm}\n" +
                                 $"Bus: {trip.Bus?.OperatorName} | Seat #{seatNumber} | Price: ${trip.TicketPrice:F2}";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter both First Name and Last Name.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(mskPhone.Text) || mskPhone.Text.Contains("_"))
            {
                MessageBox.Show("Please provide a valid Phone Number.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Passenger = new Customer
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                PhoneNumber = mskPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                IdentityNumber = txtIdentity.Text.Trim(),
                Gender = rbMale.Checked ? Gender.Male : Gender.Female
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
