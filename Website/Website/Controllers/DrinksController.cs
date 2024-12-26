using Microsoft.AspNetCore.Mvc;
using Website.Services; // Adjust the namespace as needed
using System.Threading.Tasks;

namespace Website.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinksController : ControllerBase
    {
        private readonly DrinkDataService _drinkDataService;

        public DrinksController(DrinkDataService drinkDataService)
        {
            _drinkDataService = drinkDataService;
        }

        [HttpGet("liquids")]
        public async Task<IActionResult> GetLiquids()
        {
            var liquids = await _drinkDataService.GetLiquidsAsync();
            return Ok(liquids);
        }

        [HttpGet("alcohols")]
        public async Task<IActionResult> GetAlcohols()
        {
            var alcohols = await _drinkDataService.GetAlcoholsAsync();
            return Ok(alcohols);
        }

        // Add other methods as needed
    }
}
