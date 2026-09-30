# This is a Advanced Bus Ticket System in C#.

The AdvancedBusTicketSystem enterprise-grade C# Windows Forms application targeting .NET Framework 4.7.2

# Architecture

<ul>
  <li>Program.cs</li>
  <li>App.config</li>
  <li>AdvancedBusTicketSystem.csproj</li>
  <li>AdvancedBusTicketSystem.sln</li>
  <li>Properties/AssemblyInfo.cs</li>

  <li>Domain/Entities/BaseEntity.cs</li>
  <li>Domain/Entities/Bus.cs</li>
  <li>Domain/Entities/Route.cs</li>
  <li>Domain/Entities/Trip.cs</li>
  <li>Domain/Entities/Customer.cs</li>
  <li>Domain/Entities/Ticket.cs</li>

  <li>Domain/Enums/Gender.cs</li>
  <li>Domain/Enums/BusType.cs</li>
  <li>Domain/Enums/SeatStatus.cs</li>
  <li>Domain/Enums/TicketStatus.cs</li>

  <li>Data/Repositories/IRepository.cs</li>
  <li>Data/Repositories/Repository.cs</li>
  <li>Data/Repositories/ITripRepository.cs</li>
  <li>Data/Repositories/TripRepository.cs</li>
  <li>Data/Repositories/ITicketRepository.cs</li>
  <li>Data/Repositories/TicketRepository.cs</li>

  <li>Data/Persistence/AppDbContext.cs</li>
  <li>Data/Persistence/JsonStorageService.cs</li>

  <li>Services/TicketService.cs</li>
  <li>Services/TripService.cs</li>
  <li>Services/RevenueService.cs</li>

  <li>UI/MainForm.cs</li>
  <li>UI/MainForm.Designer.cs</li>
  <li>UI/BookingModalForm.cs</li>
  <li>UI/BookingModalForm.Designer.cs</li>
  <li>UI/TicketDetailsForm.cs</li>
  <li>UI/TicketDetailsForm.Designer.cs</li>
  <li>UI/Controls/BusSeatMapControl.cs</li>
</ul>


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
