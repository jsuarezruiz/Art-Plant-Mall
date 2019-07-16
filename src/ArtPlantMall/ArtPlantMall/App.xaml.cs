using ArtPlantMall.Services;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ArtPlantMall
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitNavigation();
        }

        Task InitNavigation()
        {
            return NavigationService.Instance.InitializeAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
