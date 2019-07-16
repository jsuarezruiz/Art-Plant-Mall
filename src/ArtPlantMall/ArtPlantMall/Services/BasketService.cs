using ArtPlantMall.Models;
using System.Collections.Generic;

namespace ArtPlantMall.Services
{
    public class BasketService
    {
        public static BasketService _instance;

        public static BasketService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BasketService();

                return _instance;
            }
        }

        public List<BasketItem> GetActualBasket()
        {
            return new List<BasketItem>
            {
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Sebastian", ProductImage = "sebastian.png", UnitPrice = 13, Quantity = 1 },
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Angelica", ProductImage = "angelica.png", UnitPrice = 12, Quantity = 1  },
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Samantha", ProductImage = "samantha.png", UnitPrice = 18, Quantity = 1  },
                new BasketItem { BasketItemType = BasketItemType.Delivery, UnitPrice = 20 }
            };
        }
    }
}