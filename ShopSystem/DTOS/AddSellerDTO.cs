using ShopSystem.Models;

namespace ShopSystem.DTOS
{
    public class AddSellerDTO
    {
       
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }

        //Many Customer 
       
        //FK Team
      
        //Nav 
        public TeamInAddSellerDTO team { get; set; }
    }
    public class TeamInAddSellerDTO
    {
       
        public string Name { get; set; }
        public string? Description { get; set; }

        //Mant Seller 
        
    }
}
