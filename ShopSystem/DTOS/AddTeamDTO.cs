using ShopSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace ShopSystem.DTOS
{
    public class AddTeamDTO
    {
        [Required(ErrorMessage ="This Field is Required")]
        public string Name { get; set; }
        public string? Description { get; set; }

        //Mant Seller 
        

    }
}
