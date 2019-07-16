using ArtPlantMall.Models;
using System.Collections.Generic;

namespace ArtPlantMall.Services
{
    public class PlantsService
    {
        public static PlantsService _instance;

        public static PlantsService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PlantsService();

                return _instance;
            }
        }

        public List<Plant> GetPlants()
        {
            return new List<Plant>
            {
                new Plant { Id = 1, Name = "Angelica", Image = "angelica.png", Price = 12, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Plant { Id = 2, Name = "Jennifer", Image = "jennifer.png", Price = 26, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Plant { Id = 3, Name = "Samantha", Image = "samantha.png", Price = 13, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Plant { Id = 4, Name = "Sebastian", Image = "sebastian.png", Price = 16, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Plant { Id = 5, Name = "Miguel", Image = "miguel.png", Price = 30, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Plant { Id = 6, Name = "Javier", Image = "javier.png", Price = 7, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." }
            };
        }
    }
}