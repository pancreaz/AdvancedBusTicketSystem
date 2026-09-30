# This is a Advanced Bus Ticket System in C#.

The AdvancedBusTicketSystem enterprise-grade C# Windows Forms application targeting .NET Framework 4.7.2

# Architecture

AdvancedBusTicketSystem/
├── Program.cs                            # WinForms Application Entry Point ([STAThread])
├── App.config                            # .NET Framework 4.7.2 Configuration
├── AdvancedBusTicketSystem.csproj        # MSBuild C# Project File
├── AdvancedBusTicketSystem.sln           # Standalone Project Solution
├── Properties/
│   └── AssemblyInfo.cs                   # Assembly Metadata
├── Domain/
│   ├── Entities/
│   │   ├── BaseEntity.cs                 # Base Guid Id, CreatedAt, IsActive
│   │   ├── Bus.cs                        # Operator, LicensePlate, Capacity, BusType (VIP 2+1 vs Standard 2+2)
│   │   ├── Route.cs                      # Origin, Destination, DistanceKm, BasePrice
│   │   ├── Trip.cs                       # Route, Bus, DepartureDate, DepartureTime, TicketPrice
│   │   ├── Customer.cs                   # FirstName, LastName, Phone, Email, IdentityNo, Gender
│   │   └── Ticket.cs                     # PNR Code, TripId, SeatNumber, Customer, BookingDate, Status, PricePaid
│   └── Enums/
│       ├── Gender.cs                     # Male, Female, Other
│       ├── BusType.cs                    # VIP_2x1, Standard_2x2
│       ├── SeatStatus.cs                 # Available, Selected, ReservedMale, ReservedFemale, Blocked
│       └── TicketStatus.cs               # Confirmed, Cancelled, Completed
├── Data/
│   ├── Repositories/
│   │   ├── IRepository.cs / Repository.cs             # Generic Repository pattern with soft delete
│   │   ├── ITripRepository.cs / TripRepository.cs     # Route & date filtered trip queries
│   │   └── ITicketRepository.cs / TicketRepository.cs # PNR search & trip ticket occupancy queries
│   └── Persistence/
│       ├── AppDbContext.cs               # Singleton DbContext with data seeder & navigation linker
│       └── JsonStorageService.cs         # JSON File Persistence (saves/loads data to DataStore/*.json)
├── Services/
│   ├── TicketService.cs                  # Booking validation, auto PNR generation, cancellation & refund
│   ├── TripService.cs                    # Trip scheduling & seat occupancy status generator
│   └── RevenueService.cs                 # Financial analytics (Revenue, Ticket Count, Occupancy %)
└── UI/
    ├── MainForm.cs / Designer            # Tabbed Dashboard (Booking Engine, Ticket Manager, Analytics, Fleet)
    ├── BookingModalForm.cs / Designer    # Passenger Registration & Payment Dialog
    ├── TicketDetailsForm.cs / Designer   # Printable Travel Voucher & Receipt Exporter
    └── Controls/
        └── BusSeatMapControl.cs          # Custom interactive seat layout renderer (2+1 VIP & 2+2 Standard)


# Key Features

<ol>
  <li>
    <strong>Multi-Layout Interactive Seat Map Control</strong>
    <ul>
      <li>Renders <strong>2+1 VIP</strong> layouts (single seats left, aisle, double seats right) and <strong>2+2 Standard</strong> layouts (double seats on both sides).</li>
      <li>Real-time color coding: Green (Available), Blue (Reserved Male), Pink (Reserved Female), Orange (Selected), Gray (Blocked).</li>
    </ul>
  </li>

  <li>
    <strong>Passenger Registration &amp; Ticket Issue Engine</strong>
    <ul>
      <li>Collects passenger name, phone, email, identity number, and gender.</li>
      <li>Generates unique alphanumeric PNR codes (e.g. <code>PNR-849201</code>).</li>
    </ul>
  </li>

  <li>
    <strong>Ticket Manager &amp; PNR Lookup</strong>
    <ul>
      <li>Quick PNR search box.</li>
      <li>View formatted printable receipt voucher.</li>
      <li>Instant ticket cancellation &amp; seat release.</li>
    </ul>
  </li>

  <li>
    <strong>Financial &amp; Revenue Analytics Dashboard</strong>
    <ul>
      <li>Real-time metric cards for Total Revenue ($), Tickets Issued, Active Trips, and Overall Bus Occupancy Rate (%).</li>
    </ul>
  </li>

  <li>
    <strong>JSON Storage Persistence</strong>
    <ul>
      <li>All trips, buses, customers, and tickets are automatically saved to <code>DataStore/*.json</code> files and loaded when the application starts.</li>
    </ul>
  </li>
</ol>

# Executable generated at: r:\Study\Learning\C#\Projects\OtobusTicketProject-master\OtobusTicketProject-master\AdvancedBusTicketSystem\bin\Debug\AdvancedBusTicketSystem.exe
