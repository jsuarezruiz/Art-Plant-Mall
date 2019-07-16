using Xamarin.Forms;

namespace ArtPlantMall.Views
{
    public partial class PlantDetailView : ContentPage
    {
        public PlantDetailView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Parallax.ParallaxView = HeaderView;
        }
    }
}