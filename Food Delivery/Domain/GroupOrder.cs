namespace FoodDelivery.Domain
{
    public class GroupOrder : BaseDomainModel
    {
        public string? GroupCode { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? Status { get; set; }
        public DateTime? ClosedTime { get; set; }

        // Foreign Keys
        public int MallId { get; set; }
        public int UserId { get; set; }

        // Navigation
        public Mall? Mall { get; set; }
        public User? User { get; set; }

        public ICollection<GroupOrderMember>? GroupOrderMembers { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}

