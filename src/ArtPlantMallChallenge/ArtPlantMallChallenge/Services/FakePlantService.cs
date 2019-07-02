using ArtPlantMallChallenge.Models;
using System.Collections.Generic;

namespace ArtPlantMallChallenge.Services
{
    public class FakePlantService
    {
        private static FakePlantService _instance;

        public static FakePlantService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FakePlantService();
                return _instance;
            }
        }
        public List<Plant> GetPlants()
        {
            return new List<Plant>
            {
                new Plant { Name = "Angelica", Image = "angelica.png", Price= 12, Description = "" },
                new Plant { Name = "Jennifer", Image = "jennifer.png", Price= 26, Description = "" },
                new Plant { Name = "Samantha", Image = "samantha.png", Price= 13, Description = "" },
                new Plant { Name = "Sebastian", Image = "sebastian.png", Price= 16, Description = "" },
                new Plant { Name = "Miguel", Image = "miguel.png", Price= 16, Description = "" },
                new Plant { Name = "Javier", Image = "javier.png", Price= 16, Description = "" }
            };
        }
    }
}
