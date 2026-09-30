using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AdvancedBusTicketSystem.Data.Repositories
{
    public interface ITripRepository : IRepository<Trip>
    {
        IEnumerable<Trip> SearchTrips(string origin, string destination, DateTime date);
    }
}
