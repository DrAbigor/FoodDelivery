

namespace FoodDelivery.Domain
{
    public class Mall : BaseDomainModel
    {
        public string? MallName { get; set; }
        public string? Address { get; set; }

        // Navigation
        public ICollection<Restaurant>? Restaurants { get; set; }
        public ICollection<GroupOrder>? GroupOrders { get; set; }
    }
}
