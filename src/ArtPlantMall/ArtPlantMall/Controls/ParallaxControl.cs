using FFImageLoading.Forms;
using Xamarin.Forms;

namespace ArtPlantMall.Controls
{
    public class ParallaxControl : ScrollView
    {
        const float ParallaxSpeed = 2.25f;

        double _height;

        public ParallaxControl()
        {
            Scrolled += (sender, e) => Parallax();
        }

        public static readonly BindableProperty ParallaxViewProperty =
            BindableProperty.Create(nameof(ParallaxControl), typeof(CachedImage), typeof(ParallaxControl), null);

        public View ParallaxView
        {
            get { return (View)GetValue(ParallaxViewProperty); }
            set { SetValue(ParallaxViewProperty, value); }
        }

        public void Parallax()
        {
            if (ParallaxView == null)
                return;

            if (_height <= 0)
                _height = ParallaxView.Height;

            var y = -(int)((float)ScrollY / ParallaxSpeed);

            if (y < 0)
                ParallaxView.TranslationY = y;
            else
                ParallaxView.TranslationY = 0;
        }
    }
}