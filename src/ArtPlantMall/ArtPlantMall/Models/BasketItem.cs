namespace ArtPlantMall.Models
{
    public enum BasketItemType
    {
        Plant,
        Delivery
    }

    public class BasketItem
    {
        public BasketItemType BasketItemType { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get { return Quantity * UnitPrice; } }
    }
}