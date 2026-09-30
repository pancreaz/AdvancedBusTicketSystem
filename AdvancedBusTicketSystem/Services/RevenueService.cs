using AdvancedBusTicketSystem.Data.Persistence;
using AdvancedBusTicketSystem.Domain.Enums;
using System.Linq;

namespace AdvancedBusTicketSystem.Services
{
    public class RevenueService
    {
        public decimal GetTotalRevenue()
        {
            var db = AppDbContext.Instance;
            return db.Tickets
                .Where(t => t.IsActive && t.Status == TicketStatus.Confirmed)
                .Sum(t => t.PricePaid);
        }

        public int GetConfirmedTicketCount()
        {
            var db = AppDbContext.Instance;
            return db.Tickets.Count(t => t.IsActive && t.Status == TicketStatus.Confirmed);
        }

        public int GetActiveTripCount()
        {
            var db = AppDbContext.Instance;
            return db.Trips.Count(t => t.IsActive);
        }

        public double GetOverallOccupancyRatePercentage()
        {
            var db = AppDbContext.Instance;
            if (db.Trips.Count == 0) return 0.0;

            int totalCapacity = db.Trips.Where(t => t.IsActive && t.Bus != null).Sum(t => t.Bus.Capacity);
            if (totalCapacity == 0) return 0.0;

            int totalBooked = db.Tickets.Count(t => t.IsActive && t.Status == TicketStatus.Confirmed);
            return (double)totalBooked / totalCapacity * 100.0;
        }
    }
}
