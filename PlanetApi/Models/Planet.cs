using Microsoft.Extensions.Options;

namespace PlanetsApi.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double DistanceFromSun { get; set; } //(10⁶ km)
        public double Mass { get; set; } //(x10²⁴kg)
        public int Diameter { get; set; } //km
        public string? AdditionalInformation { get; set; }
    }
}
