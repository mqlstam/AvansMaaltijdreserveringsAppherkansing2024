namespace AvansMaaltijdreserveringsApp.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAlcoholic { get; set; }
        public string PhotoUrl { get; set; }
    }
}