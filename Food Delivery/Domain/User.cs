namespace FoodDelivery.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }

        // Navigation
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<GroupOrder>? GroupOrders { get; set; }
        public ICollection<GroupOrderMember>? GroupOrderMembers { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<PaymentMethod>? PaymentMethods { get; set; }
    }
}
