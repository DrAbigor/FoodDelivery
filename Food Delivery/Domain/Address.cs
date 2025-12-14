namespace FoodDelivery.Domain
{
    public class Address : BaseDomainModel
    {
        public string? Block { get; set; }
        public string? UnitNumber { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }

        // Foreign Key (DEPENDENT SIDE)
        public int UserId { get; set; }

        // Navigation
        public User? User { get; set; }
    }
}
