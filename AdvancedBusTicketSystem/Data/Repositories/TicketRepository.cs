using AdvancedBusTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedBusTicketSystem.Data.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(List<Ticket> tickets, Action onSave) : base(tickets, onSave)
        {
        }

        public Ticket GetByPnr(string pnrCode)
        {
            if (string.IsNullOrWhiteSpace(pnrCode)) return null;
            return Find(t => t.PnrCode.Equals(pnrCode.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public IEnumerable<Ticket> GetTicketsByTripId(Guid tripId)
        {
            return Find(t => t.TripId == tripId && t.Status == Domain.Enums.TicketStatus.Confirmed);
        }
    }
}
