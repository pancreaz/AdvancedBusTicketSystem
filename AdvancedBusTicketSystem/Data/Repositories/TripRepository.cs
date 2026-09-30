using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedBusTicketSystem.Data.Repositories
{
    public class TripRepository : Repository<Trip>, ITripRepository
    {
        public TripRepository(List<Trip> trips, Action onSave) : base(trips, onSave)
        {
        }

        public IEnumerable<Trip> SearchTrips(string origin, string destination, DateTime date)
        {
            return Find(t => 
                (string.IsNullOrEmpty(origin) || (t.Route != null && t.Route.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase))) &&
                (string.IsNullOrEmpty(destination) || (t.Route != null && t.Route.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))) &&
                t.DepartureDate.Date == date.Date
            );
        }
    }
}
