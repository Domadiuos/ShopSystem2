using ShopSystem.Models;

namespace ShopSystem.DTOS
{
    public class GetCustomerDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //Many Seller 
        public ICollection<SellerInGetCustomer> sellers { get; set; } 
        //Nav
        public CardinGetCustomer card { get; set; }
    }
    public class SellerInGetCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }

        //Many Customer 
       

        //FK Team
       

    }
    public class CardinGetCustomer
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string? Type { get; set; }

        //FK Customer
       
        //Nav

    }
}
