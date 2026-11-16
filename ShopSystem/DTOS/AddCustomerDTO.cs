using ShopSystem.Models;

namespace ShopSystem.DTOS
{
    public class AddCustomerDTO
    {
     
        public string Name { get; set; }
        public string Email { get; set; }
        //Many Seller 
        public List<int>? sellersID { get; set; } 
        //Nav
        public CardInCustomerDTO? card { get; set; }
    }
    public class CardInCustomerDTO
    {
     
        public string? CardNumber { get; set; }
        public string? Type { get; set; }

        //FK Customer
       
        //Nav
        
    }
}
