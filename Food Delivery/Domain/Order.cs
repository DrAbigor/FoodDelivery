

namespace FoodDelivery.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime DateTime { get; set; }
        public string? Status { get; set; }
        public decimal TotalAmount { get; set; }

        // Foreign Keys
        public int UserId { get; set; }
        public int GroupOrderId { get; set; }

        // Navigation
        public User? User { get; set; }
        public GroupOrder? GroupOrder { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
        public Payment? Payment { get; set; }
    }
}