namespace AdvancedBusTicketSystem.Domain.Entities
{
    public class Route : BaseEntity
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int DistanceKm { get; set; }
        public decimal BasePrice { get; set; }

        public override string ToString()
        {
            return $"{Origin} -> {Destination} ({DistanceKm} km, Base: ${BasePrice:F2})";
        }
    }
}
