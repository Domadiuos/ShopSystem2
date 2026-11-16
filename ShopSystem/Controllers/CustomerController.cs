using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSystem.DTOS;
using ShopSystem.Models;
using ShopSystem.Repo;

namespace ShopSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepo _customerRepo;
        private readonly IMapper _mapper;
        private readonly SellerRepo _genericSeller;

        public CustomerController(CustomerRepo customerRepo, IMapper mapper, SellerRepo genericSeller)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
            _genericSeller = genericSeller;
        }
        //Add Customer
        [HttpPost]
        public  async Task<ActionResult> AddCustomer(AddCustomerDTO CustomerDTO)
        {
            
            var mapper = _mapper.Map<Customer>(CustomerDTO);

            if (CustomerDTO.sellersID != null)
            {
                foreach (var SellerId in CustomerDTO.sellersID)
                {
                    var sellerFound = await _genericSeller.GetById(SellerId);

                    if (sellerFound == null)
                        return NotFound();

                  mapper.sellers.Add(sellerFound);
                }
            }
             await _customerRepo.Add(mapper);
            return Ok("Added Succefull");
        }
        //GET By Id
        [HttpGet("{id}")]
        public  async Task<ActionResult<GetCustomerDTO?>> GetByIdCustomer(int id)
        {
            var result = await _customerRepo.GetById(id);
            if (result == null)
                return NotFound();
            var mapper = _mapper.Map<GetCustomerDTO>(result);
            return Ok(mapper);
        }

        //Update
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCustomer(AddCustomerDTO entity,int id)
        {
            var result = await _customerRepo.GetById(id);
            if(result == null )
                return NotFound();

            result.card.CardNumber = entity.card.CardNumber;
            result.card.Type = entity.card.Type;


            if (entity.sellersID != null)
            {
                entity.sellersID.Clear();
                foreach(var SellerId in entity.sellersID)
                {
                    var FoundSeller  = await _genericSeller.GetById(SellerId);
                    if (FoundSeller == null)
                        return NotFound();

                    result.sellers.Add(FoundSeller);
                }
            }
            await _customerRepo.Update(result);
            return Ok("Update Successfully");
        }
        //Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _customerRepo.Delete(id);
            if (result == false)
                return NotFound();
            return Ok("Deleted Done");
        }


    }
}
