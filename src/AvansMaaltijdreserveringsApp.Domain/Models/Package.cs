namespace AvansMaaltijdreserveringsApp.Domain.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public string City { get; set; }
        public string Canteen { get; set; }
        public DateTime PickupDateTime { get; set; }
        public DateTime PickupDeadline { get; set; }
        public bool Is18Plus { get; set; }
        public decimal Price { get; set; }
        public string MealType { get; set; }
        public int? ReservedById { get; set; }
        public Student ReservedBy { get; set; }
    }
}
