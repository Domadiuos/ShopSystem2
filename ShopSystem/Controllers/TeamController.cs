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
    public class TeamController : ControllerBase
    {
        private readonly IGeneric<Team> _genericTeam;
        private readonly IMapper _mapper;
        private readonly SellerRepo _sellerRepo;

        public TeamController(IGeneric<Team> genericTeam, IMapper mapper, SellerRepo sellerRepo)
        {
            _genericTeam = genericTeam;
            _mapper = mapper;
            _sellerRepo = sellerRepo;
        }
        [HttpPost]
        public  async Task<ActionResult> AddTeam(AddTeamDTO TeamDTO)
        {
            var mapper = _mapper.Map<Team>(TeamDTO);
            await _genericTeam.Add(mapper);
            return Ok("Added Succsuss");
        }
       
    }
}
