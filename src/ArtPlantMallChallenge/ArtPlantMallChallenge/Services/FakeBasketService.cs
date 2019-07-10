using ArtPlantMallChallenge.Models;
using System.Collections.Generic;

namespace ArtPlantMallChallenge.Services
{
    public class FakeBasketService
    {
        private static FakeBasketService _instance;

        public static FakeBasketService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FakeBasketService();
                return _instance;
            }
        }
        
        public List<BasketItem> GetActualBasket()
        {
            return new List<BasketItem>
            {
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Sebastian", ProductImage = "sebastian.png", Quantity = 1, UnitPrice = 13 },
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Angelica", ProductImage = "angelica.png", Quantity = 1, UnitPrice = 12 },
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Samantha", ProductImage = "samantha.png", Quantity = 1, UnitPrice = 18 },
                new BasketItem { BasketItemType = BasketItemType.Delivery, ProductName = "Delivery",  UnitPrice = 20 },};
        }
    }
}
