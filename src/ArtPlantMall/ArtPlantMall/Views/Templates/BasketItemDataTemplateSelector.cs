using ArtPlantMall.Models;
using Xamarin.Forms;

namespace ArtPlantMall.Views.Templates
{
    public class BasketItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PlantTemplate { get; set; }
        public DataTemplate DeliveryTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((BasketItem)item).BasketItemType == BasketItemType.Plant ? PlantTemplate : DeliveryTemplate;
        }
    }
}
