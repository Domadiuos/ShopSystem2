namespace ShopSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //Many Seller 
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();
        //Nav
        public Card card { get; set; }
    }
}
