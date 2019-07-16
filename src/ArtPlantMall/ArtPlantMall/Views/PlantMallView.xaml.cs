using Xamarin.Forms;

namespace ArtPlantMall.Views
{
    public partial class PlantMallView : ContentPage
    {
        const uint ExpandAnimationSpeed = 350;
        const uint CollapseAnimationSpeed = 250;
        const uint SharedTransitionDuration = 100;

        double pageHeight = 0;

        public PlantMallView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            CartPopup.OnExpandTapped += OnExpand;
            CartPopup.OnCollapseTapped += OnCollapse;
            base.OnAppearing();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            pageHeight = height;
            CartPopup.TranslationY = pageHeight - CartPopup.HeaderHeight;
            base.OnSizeAllocated(width, height);
        }

        protected override void OnDisappearing()
        {
            CartPopup.OnExpandTapped -= OnExpand;
            CartPopup.OnCollapseTapped -= OnCollapse;
            base.OnDisappearing();
        }

        private void OnExpand()
        {
            CartPopupFade.IsVisible = true;
            CartPopupFade.FadeTo(1, ExpandAnimationSpeed, Easing.SinInOut);

            var height = pageHeight - CartPopup.HeaderHeight;
            CartPopup.TranslateTo(0, Height - height, ExpandAnimationSpeed, Easing.SinInOut);
        }

        private void OnCollapse()
        {
            CartPopupFade.FadeTo(0, CollapseAnimationSpeed, Easing.SinInOut);
            CartPopupFade.IsVisible = false;
            CartPopup.TranslateTo(0, pageHeight - CartPopup.HeaderHeight, CollapseAnimationSpeed, Easing.SinInOut);
        }
    }
}