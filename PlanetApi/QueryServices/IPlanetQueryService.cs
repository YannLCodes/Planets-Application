using Microsoft.EntityFrameworkCore;
using PlanetsApi.Models;

namespace PlanetApi.QueryServices
{
    public interface IPlanetQueryService
    {
        public Task <IEnumerable<Planet>> GetPlanets();
        public Task <Planet> GetPlanet(int Id);
    }
}
