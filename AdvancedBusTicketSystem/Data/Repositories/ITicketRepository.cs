using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AdvancedBusTicketSystem.Data.Repositories
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Ticket GetByPnr(string pnrCode);
        IEnumerable<Ticket> GetTicketsByTripId(Guid tripId);
    }
}
