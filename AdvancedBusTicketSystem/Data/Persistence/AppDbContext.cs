using AdvancedBusTicketSystem.Domain.Entities;
using AdvancedBusTicketSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdvancedBusTicketSystem.Data.Persistence
{
    public class AppDbContext
    {
        private static AppDbContext _instance;
        private static readonly object _lock = new object();

        public static AppDbContext Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppDbContext();
                    }
                    return _instance;
                }
            }
        }

        private readonly JsonStorageService _storage;
        private readonly string _dataDir;

        public List<Bus> Buses { get; private set; }
        public List<Route> Routes { get; private set; }
        public List<Trip> Trips { get; private set; }
        public List<Customer> Customers { get; private set; }
        public List<Ticket> Tickets { get; private set; }

        private AppDbContext()
        {
            _storage = new JsonStorageService();
            _dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataStore");

            LoadData();
            SeedInitialDataIfEmpty();
            ConnectNavigationProperties();
        }

        public void LoadData()
        {
            Buses = _storage.LoadFromFile<Bus>(Path.Combine(_dataDir, "buses.json"));
            Routes = _storage.LoadFromFile<Route>(Path.Combine(_dataDir, "routes.json"));
            Trips = _storage.LoadFromFile<Trip>(Path.Combine(_dataDir, "trips.json"));
            Customers = _storage.LoadFromFile<Customer>(Path.Combine(_dataDir, "customers.json"));
            Tickets = _storage.LoadFromFile<Ticket>(Path.Combine(_dataDir, "tickets.json"));
        }

        public void SaveChanges()
        {
            _storage.SaveToFile(Path.Combine(_dataDir, "buses.json"), Buses);
            _storage.SaveToFile(Path.Combine(_dataDir, "routes.json"), Routes);
            _storage.SaveToFile(Path.Combine(_dataDir, "trips.json"), Trips);
            _storage.SaveToFile(Path.Combine(_dataDir, "customers.json"), Customers);
            _storage.SaveToFile(Path.Combine(_dataDir, "tickets.json"), Tickets);
        }

        public void ConnectNavigationProperties()
        {
            foreach (var trip in Trips)
            {
                trip.Bus = Buses.FirstOrDefault(b => b.Id == trip.BusId);
                trip.Route = Routes.FirstOrDefault(r => r.Id == trip.RouteId);
            }

            foreach (var ticket in Tickets)
            {
                ticket.Trip = Trips.FirstOrDefault(t => t.Id == ticket.TripId);
                ticket.Customer = Customers.FirstOrDefault(c => c.Id == ticket.CustomerId);
            }
        }

        private void SeedInitialDataIfEmpty()
        {
            if (Buses.Count == 0)
            {
                Buses.AddRange(new[]
                {
                    new Bus { OperatorName = "Metro Express", LicensePlate = "34-MET-101", Capacity = 30, LayoutType = BusType.VIP_2x1 },
                    new Bus { OperatorName = "Nilufer Tourism", LicensePlate = "16-NIL-202", Capacity = 36, LayoutType = BusType.Standard_2x2 },
                    new Bus { OperatorName = "Pamukkale Travel", LicensePlate = "20-PAM-303", Capacity = 32, LayoutType = BusType.VIP_2x1 },
                    new Bus { OperatorName = "FlixLines Express", LicensePlate = "06-FLX-404", Capacity = 40, LayoutType = BusType.Standard_2x2 }
                });
            }

            if (Routes.Count == 0)
            {
                Routes.AddRange(new[]
                {
                    new Route { Origin = "New York", Destination = "Boston", DistanceKm = 350, BasePrice = 45.00m },
                    new Route { Origin = "New York", Destination = "Washington DC", DistanceKm = 360, BasePrice = 50.00m },
                    new Route { Origin = "London", Destination = "Manchester", DistanceKm = 330, BasePrice = 40.00m },
                    new Route { Origin = "Istanbul", Destination = "Ankara", DistanceKm = 450, BasePrice = 35.00m },
                    new Route { Origin = "Istanbul", Destination = "Izmir", DistanceKm = 480, BasePrice = 38.00m }
                });
            }

            if (Trips.Count == 0)
            {
                DateTime today = DateTime.Today;
                var metroBus = Buses.First(b => b.OperatorName.Contains("Metro"));
                var niluferBus = Buses.First(b => b.OperatorName.Contains("Nilufer"));
                var pamukkaleBus = Buses.First(b => b.OperatorName.Contains("Pamukkale"));

                var nyBoston = Routes.First(r => r.Origin == "New York" && r.Destination == "Boston");
                var nyDc = Routes.First(r => r.Origin == "New York" && r.Destination == "Washington DC");
                var istAnk = Routes.First(r => r.Origin == "Istanbul" && r.Destination == "Ankara");

                Trips.AddRange(new[]
                {
                    new Trip { BusId = metroBus.Id, RouteId = nyBoston.Id, DepartureDate = today, DepartureTime = new TimeSpan(9, 0, 0), TicketPrice = 55.00m },
                    new Trip { BusId = niluferBus.Id, RouteId = nyBoston.Id, DepartureDate = today, DepartureTime = new TimeSpan(13, 30, 0), TicketPrice = 48.00m },
                    new Trip { BusId = pamukkaleBus.Id, RouteId = nyDc.Id, DepartureDate = today, DepartureTime = new TimeSpan(10, 15, 0), TicketPrice = 60.00m },
                    new Trip { BusId = metroBus.Id, RouteId = istAnk.Id, DepartureDate = today.AddDays(1), DepartureTime = new TimeSpan(11, 0, 0), TicketPrice = 40.00m }
                });
            }

            if (Customers.Count == 0)
            {
                Customers.AddRange(new[]
                {
                    new Customer { FirstName = "John", LastName = "Smith", PhoneNumber = "(555) 123-4567", Email = "john.smith@example.com", Gender = Gender.Male, IdentityNumber = "ID1001" },
                    new Customer { FirstName = "Emma", LastName = "Watson", PhoneNumber = "(555) 987-6543", Email = "emma.w@example.com", Gender = Gender.Female, IdentityNumber = "ID1002" }
                });
            }

            if (Tickets.Count == 0 && Trips.Count > 0 && Customers.Count > 0)
            {
                var trip = Trips[0];
                var john = Customers[0];
                var emma = Customers[1];

                Tickets.AddRange(new[]
                {
                    new Ticket { PnrCode = "PNR-1001", TripId = trip.Id, CustomerId = john.Id, SeatNumber = 3, PricePaid = trip.TicketPrice, Status = TicketStatus.Confirmed },
                    new Ticket { PnrCode = "PNR-1002", TripId = trip.Id, CustomerId = emma.Id, SeatNumber = 4, PricePaid = trip.TicketPrice, Status = TicketStatus.Confirmed }
                });
            }

            SaveChanges();
        }
    }
}
