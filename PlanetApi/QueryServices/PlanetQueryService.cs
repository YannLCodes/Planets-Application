using Microsoft.EntityFrameworkCore;
using PlanetsApi.Models;
using System.Linq;

namespace PlanetApi.QueryServices
{
    public class PlanetQueryService : IPlanetQueryService
    {
        private readonly ILogger<PlanetQueryService> _logger;
        private readonly AstronomyDbContext _dbContext;

        public PlanetQueryService(ILogger<PlanetQueryService> logger, AstronomyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Planet>> GetPlanets()
        {
            return await _dbContext.Planets.ToListAsync();
        }

        public async Task<Planet> GetPlanet(int Id)
        {
            var matchById = await _dbContext.Planets.Where(x => x.Id == Id).ToListAsync();
            if (matchById.Count() < 1)
            {
                return null;
            }
            return matchById.FirstOrDefault();
        }
    }
}
