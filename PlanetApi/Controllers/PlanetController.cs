using Microsoft.AspNetCore.Mvc;
using PlanetApi.QueryServices;
using PlanetsApi.Models;

namespace PlanetsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetController : ControllerBase
    {

        private readonly ILogger<PlanetController> _logger;
        private readonly IPlanetQueryService _planetQueryService;

        public PlanetController(ILogger<PlanetController> logger, IPlanetQueryService planetQueryService )
        {
            _logger = logger;
            _planetQueryService = planetQueryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allPlanets = await _planetQueryService.GetPlanets();
            return Ok(allPlanets);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
                var planet = await _planetQueryService.GetPlanet(id);
                if (planet == null) return NotFound();
                return Ok(planet);
        }
    }
}