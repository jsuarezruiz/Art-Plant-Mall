using ArtPlantMallChallenge.Models;
using ArtPlantMallChallenge.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ArtPlantMallChallenge.ViewModels
{
    public class ArtPlantMallViewModel : BindableObject
    {
        private Plant _selectedPlant;
        private ObservableCollection<Plant> _plants;
        private ObservableCollection<BasketItem> _basket;

        public ArtPlantMallViewModel()
        {
            LoadData();
        }

        public Plant SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
                OnPropertyChanged();
            }
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

        public ObservableCollection<BasketItem> Basket
        {
            get { return _basket; }
            set
            {
                _basket = value;
                OnPropertyChanged();
            }
        }

        public ICommand PlantDetailCommand => new Command(NavigateToPlantDetail);

        private void LoadData()
        {
            Plants = new ObservableCollection<Plant>(FakePlantService.Instance.GetPlants());
            Basket = new ObservableCollection<BasketItem>(FakeBasketService.Instance.GetActualBasket());
        }

        private void NavigateToPlantDetail()
        {
            //NavigationService.Instance.NavigateTo<PlantDetailViewModel>(SelectedPlant);
        }
    }
}
