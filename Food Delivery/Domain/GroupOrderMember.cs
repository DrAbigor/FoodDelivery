
namespace FoodDelivery.Domain
{
    public class GroupOrderMember : BaseDomainModel
    {
        public DateTime JoinTime { get; set; }
        public string? Status { get; set; }

        // Foreign Keys
        public int GroupOrderId { get; set; }
        public int UserId { get; set; }

        // Navigation
        public GroupOrder? GroupOrder { get; set; }
        public User? User { get; set; }
    }
}