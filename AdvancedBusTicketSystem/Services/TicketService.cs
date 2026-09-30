using AdvancedBusTicketSystem.Data.Persistence;
using AdvancedBusTicketSystem.Data.Repositories;
using AdvancedBusTicketSystem.Domain.Entities;
using AdvancedBusTicketSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedBusTicketSystem.Services
{
    public class TicketService
    {
        private readonly TicketRepository _ticketRepo;
        private readonly Repository<Customer> _customerRepo;
        private readonly TripRepository _tripRepo;

        public TicketService()
        {
            var db = AppDbContext.Instance;
            _ticketRepo = new TicketRepository(db.Tickets, db.SaveChanges);
            _customerRepo = new Repository<Customer>(db.Customers, db.SaveChanges);
            _tripRepo = new TripRepository(db.Trips, db.SaveChanges);
        }

        public string GenerateUniquePnr()
        {
            Random rand = new Random();
            string pnr;
            do
            {
                pnr = $"PNR-{rand.Next(100000, 999999)}";
            } while (_ticketRepo.GetByPnr(pnr) != null);

            return pnr;
        }

        public bool IsSeatAvailable(Guid tripId, int seatNumber)
        {
            return !_ticketRepo.GetTicketsByTripId(tripId)
                .Any(t => t.SeatNumber == seatNumber && t.Status == TicketStatus.Confirmed);
        }

        public Ticket IssueTicket(Guid tripId, Customer customer, int seatNumber, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (customer == null || string.IsNullOrWhiteSpace(customer.FirstName) || string.IsNullOrWhiteSpace(customer.LastName))
            {
                errorMessage = "Customer name details are required.";
                return null;
            }

            if (!IsSeatAvailable(tripId, seatNumber))
            {
                errorMessage = $"Seat #{seatNumber} is already booked for this trip.";
                return null;
            }

            Trip trip = _tripRepo.GetById(tripId);
            if (trip == null)
            {
                errorMessage = "Target trip was not found.";
                return null;
            }

            // Find existing customer by phone or identity number, or add new
            Customer existingCustomer = _customerRepo.Find(c => 
                (!string.IsNullOrEmpty(customer.IdentityNumber) && c.IdentityNumber == customer.IdentityNumber) ||
                (!string.IsNullOrEmpty(customer.PhoneNumber) && c.PhoneNumber == customer.PhoneNumber)
            ).FirstOrDefault();

            if (existingCustomer == null)
            {
                _customerRepo.Add(customer);
                existingCustomer = customer;
            }

            Ticket newTicket = new Ticket
            {
                PnrCode = GenerateUniquePnr(),
                TripId = tripId,
                CustomerId = existingCustomer.Id,
                SeatNumber = seatNumber,
                PricePaid = trip.TicketPrice,
                Status = TicketStatus.Confirmed,
                BookingDate = DateTime.Now,
                Trip = trip,
                Customer = existingCustomer
            };

            _ticketRepo.Add(newTicket);
            AppDbContext.Instance.ConnectNavigationProperties();
            return newTicket;
        }

        public bool CancelTicket(string pnrCode, out string message)
        {
            Ticket ticket = _ticketRepo.GetByPnr(pnrCode);
            if (ticket == null)
            {
                message = "Ticket with the specified PNR code was not found.";
                return false;
            }

            if (ticket.Status == TicketStatus.Cancelled)
            {
                message = "This ticket is already cancelled.";
                return false;
            }

            ticket.Status = TicketStatus.Cancelled;
            _ticketRepo.Update(ticket);
            AppDbContext.Instance.SaveChanges();

            message = $"Ticket {pnrCode} for seat #{ticket.SeatNumber} has been successfully cancelled.";
            return true;
        }

        public Ticket GetTicketByPnr(string pnrCode)
        {
            return _ticketRepo.GetByPnr(pnrCode);
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _ticketRepo.GetAll();
        }
    }
}
