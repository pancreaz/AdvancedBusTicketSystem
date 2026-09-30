using AdvancedBusTicketSystem.Domain.Enums;

namespace AdvancedBusTicketSystem.Domain.Entities
{
    public class Bus : BaseEntity
    {
        public string OperatorName { get; set; }
        public string LicensePlate { get; set; }
        public int Capacity { get; set; }
        public BusType LayoutType { get; set; }

        public override string ToString()
        {
            return $"{OperatorName} ({LicensePlate}) - {LayoutType} [{Capacity} seats]";
        }
    }
}
