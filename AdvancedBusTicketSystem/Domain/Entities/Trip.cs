using System;

namespace AdvancedBusTicketSystem.Domain.Entities
{
    public class Trip : BaseEntity
    {
        public Guid BusId { get; set; }
        public Guid RouteId { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public decimal TicketPrice { get; set; }

        // Navigation properties (Ignored during JSON serialization or populated dynamically)
        public Bus Bus { get; set; }
        public Route Route { get; set; }

        public override string ToString()
        {
            string dateStr = DepartureDate.ToString("yyyy-MM-dd");
            string timeStr = DepartureTime.ToString(@"hh\:mm");
            string routeStr = Route != null ? $"{Route.Origin} -> {Route.Destination}" : "Route";
            string busStr = Bus != null ? Bus.OperatorName : "Bus";
            return $"[{dateStr} {timeStr}] {busStr}: {routeStr} (${TicketPrice:F2})";
        }
    }
}
