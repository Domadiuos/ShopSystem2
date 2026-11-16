namespace ShopSystem.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Email { get; set; }
        public string? Phone { get; set; }

        //Many Customer 
        public ICollection<Customer> customers { get; set; } = new List<Customer>();

        //FK Team
        public int TeamId { get; set; }
        //Nav 
        public Team team { get; set; }

    }
}
