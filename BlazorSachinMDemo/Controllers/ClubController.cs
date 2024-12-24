using BlazorSachinMDemo.Components.Pages;
using BlazorSachinMDemo.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSachinMDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private IClubService _clubService;
        public ClubController(IClubService clubService)
        {
                _clubService = clubService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()       
        {
            return Ok(await _clubService.GetClubs());
        }
        [HttpPost]
        public async Task<IActionResult> Post(Models.Club club)
        {
            if (club.Id == 0)
            {
                await _clubService.AddClub(club);
                return Ok(club.Id);
            }
            else
            {
                await _clubService.UpdateClub(club);
                return Ok(club.Id);
            }         
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            return Ok(await _clubService.GetClub(id));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clubService.DeleteClub(id);
            return Ok();
        }
    }
}
