using ShopSystem.Models;

namespace ShopSystem.DTOS
{
    public class GetSellerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }

        //Many Customer 
        

        //FK Team
      
        //Nav 
        public TeamInGetSeller team { get; set; }
    }
    public class TeamInGetSeller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        //Mant Seller 
      
    }
}
