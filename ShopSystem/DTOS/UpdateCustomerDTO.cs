using ShopSystem.Models;

namespace ShopSystem.DTOS
{
    public class UpdateCustomerDTO
    {
      
        public string Name { get; set; }
        public string Email { get; set; }
        //Many Seller 
        public List<int> sellersID { get; set; } 
        //Nav
        public CardInUpdateDTO card { get; set; }
    }
    public class CardInUpdateDTO
    {

        public string CardNumber { get; set; }
        public string? Type { get; set; }

        //FK Customer

        //Nav
    }
}
