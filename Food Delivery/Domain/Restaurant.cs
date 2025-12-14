namespace FoodDelivery.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? CuisineType { get; set; }
        public string? OperatingHours { get; set; }
        public string? LocationWithinMall { get; set; }

        // Foreign Key
        public int MallId { get; set; }

        // Navigation
        public Mall? Mall { get; set; }
        public ICollection<MenuItem>? MenuItems { get; set; }
    }
}
