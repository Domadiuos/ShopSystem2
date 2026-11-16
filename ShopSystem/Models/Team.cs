namespace ShopSystem.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string?  Description { get; set; }

        //Mant Seller 
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();
    }
}
