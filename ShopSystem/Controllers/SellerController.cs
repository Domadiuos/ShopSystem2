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
    public class SellerController : ControllerBase
    {
        private readonly IGeneric<Team> _genericTeam;
        private readonly IMapper _mapper;
        private readonly SellerRepo _sellerRepo;

        public SellerController(IGeneric<Team> genericTeam, IMapper mapper, SellerRepo sellerRepo)
        {
            _genericTeam = genericTeam;
            _mapper = mapper;
            _sellerRepo = sellerRepo;
        }
        //Add Seller 
        [HttpPost]
        public async Task<ActionResult> AddSeller(AddSellerDTO sellerDTO)
        {
            var mapper = _mapper.Map<Seller>(sellerDTO);
            await _sellerRepo.Add(mapper);
            return Ok("Added Succsuss");
        }
        //GET By Id
        [HttpGet("{id}")]
        public  async Task<ActionResult<GetSellerDTO?>> GetById(int id)
        {
            var result = await _sellerRepo.GetById(id);
            
            if (result == null)
                return NotFound();
            var mapper = _mapper.Map<GetSellerDTO>(result);
            return Ok(mapper);
                    
        }

    }
}
