namespace AvansMaaltijdreserveringsApp.Domain.Models
{
    public class Canteen
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public bool OffersWarmMeals { get; set; }
    }
}