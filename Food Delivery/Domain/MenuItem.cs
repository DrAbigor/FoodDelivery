

namespace FoodDelivery.Domain
{
    public class MenuItem : BaseDomainModel
    {
        public string? ItemName { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? NutritionInfo { get; set; }

        // Foreign Key
        public int RestaurantId { get; set; }

        // Navigation
        public Restaurant? Restaurant { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
