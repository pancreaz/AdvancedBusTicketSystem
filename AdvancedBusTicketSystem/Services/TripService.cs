using AdvancedBusTicketSystem.Data.Persistence;
using AdvancedBusTicketSystem.Data.Repositories;
using AdvancedBusTicketSystem.Domain.Entities;
using AdvancedBusTicketSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedBusTicketSystem.Services
{
    public class TripService
    {
        private readonly TripRepository _tripRepo;
        private readonly TicketRepository _ticketRepo;

        public TripService()
        {
            var db = AppDbContext.Instance;
            _tripRepo = new TripRepository(db.Trips, db.SaveChanges);
            _ticketRepo = new TicketRepository(db.Tickets, db.SaveChanges);
        }

        public IEnumerable<Trip> GetAllTrips()
        {
            return _tripRepo.GetAll();
        }

        public IEnumerable<Trip> SearchTrips(string origin, string destination, DateTime date)
        {
            return _tripRepo.SearchTrips(origin, destination, date);
        }

        public Trip GetTripById(Guid tripId)
        {
            return _tripRepo.GetById(tripId);
        }

        public Dictionary<int, SeatStatus> GetSeatOccupancyForTrip(Guid tripId)
        {
            Dictionary<int, SeatStatus> seatMap = new Dictionary<int, SeatStatus>();
            Trip trip = GetTripById(tripId);
            if (trip == null || trip.Bus == null) return seatMap;

            int capacity = trip.Bus.Capacity;
            for (int i = 1; i <= capacity; i++)
            {
                seatMap[i] = SeatStatus.Available;
            }

            var confirmedTickets = _ticketRepo.GetTicketsByTripId(tripId);
            foreach (var ticket in confirmedTickets)
            {
                if (ticket.SeatNumber >= 1 && ticket.SeatNumber <= capacity)
                {
                    if (ticket.Customer != null && ticket.Customer.Gender == Gender.Female)
                    {
                        seatMap[ticket.SeatNumber] = SeatStatus.ReservedFemale;
                    }
                    else
                    {
                        seatMap[ticket.SeatNumber] = SeatStatus.ReservedMale;
                    }
                }
            }

            return seatMap;
        }
    }
}
