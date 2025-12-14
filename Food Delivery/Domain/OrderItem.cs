namespace FoodDelivery.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Subtotal { get; set; }

        // Foreign Keys
        public int ItemId { get; set; }
        public int OrderId { get; set; }

        // Navigation
        public MenuItem? MenuItem { get; set; }
        public Order? Order { get; set; }
    }
}
