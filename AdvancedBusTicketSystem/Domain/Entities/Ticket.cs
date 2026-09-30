using AdvancedBusTicketSystem.Domain.Enums;
using System;

namespace AdvancedBusTicketSystem.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public string PnrCode { get; set; }
        public Guid TripId { get; set; }
        public Guid CustomerId { get; set; }
        public int SeatNumber { get; set; }
        public decimal PricePaid { get; set; }
        public TicketStatus Status { get; set; } = TicketStatus.Confirmed;
        public DateTime BookingDate { get; set; } = DateTime.Now;

        // Navigation properties
        public Trip Trip { get; set; }
        public Customer Customer { get; set; }

        public override string ToString()
        {
            return $"[{PnrCode}] Seat #{SeatNumber} - Customer: {Customer?.FullName} - Status: {Status}";
        }
    }
}
