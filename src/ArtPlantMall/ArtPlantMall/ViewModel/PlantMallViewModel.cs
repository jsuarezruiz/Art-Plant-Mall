using ArtPlantMall.Models;
using ArtPlantMall.Services;
using ArtPlantMall.ViewModel.Base;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ArtPlantMall.ViewModel
{
    public class PlantMallViewModel : ViewModelBase
    {
        private ObservableCollection<Plant> _plants;
        private Plant _selectedPlant;
        public ObservableCollection<BasketItem> _basket;
        public decimal _total;

        public PlantMallViewModel()
        {
            LoadPlants();
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

        public Plant SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
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

        public decimal Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectCommand => new Command(NavigateToPlantDetail);

        private void LoadPlants()
        {
            Plants = new ObservableCollection<Plant>(PlantsService.Instance.GetPlants());
            var actualBasket = BasketService.Instance.GetActualBasket();
            Basket = new ObservableCollection<BasketItem>(actualBasket);
            Total = actualBasket.Sum(b => b.UnitPrice * b.Quantity);
        }

        private void NavigateToPlantDetail()
        {
            NavigationService.Instance.NavigateToAsync<PlantDetailViewModel>(SelectedPlant);
        }
    }
}