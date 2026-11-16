namespace ShopSystem.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string?  Type { get; set; }

        //FK Customer
        public int CustomerId { get; set; }
        //Nav
        public Customer customer { get; set; }
    }
}
