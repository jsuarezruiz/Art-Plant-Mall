using ArtPlantMallChallenge.Models;
using ArtPlantMallChallenge.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ArtPlantMallChallenge.ViewModels
{
    public class ArtPlantMallViewModel : BindableObject
    {
        private ObservableCollection<Plant> _plants;

        public ArtPlantMallViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Plant> Plants
        {
            get { return _plants; }
            set
            {
                _plants = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Plants = new ObservableCollection<Plant>(FakePlantService.Instance.GetPlants());
        }
    }
}
