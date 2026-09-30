using AdvancedBusTicketSystem.Domain.Enums;

namespace AdvancedBusTicketSystem.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public Gender Gender { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{FullName} ({PhoneNumber}) - {Gender}";
        }
    }
}
