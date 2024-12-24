using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingBasket.Models;

namespace ShoppingBasket.Services
{
    public class BasketService
    {
        private readonly List<Item> _items = new List<Item>
        {
            new Item { Name = "Apple", Price = 35 },
            new Item { Name = "Banana", Price = 20 },
            new Item { Name = "Melon", Price = 50 },
            new Item { Name = "Lime", Price = 15 }
        };

        public int CalculateTotalCost(List<string> basket)
        {
            var itemCounts = basket.GroupBy(item => item)
                                   .ToDictionary(group => group.Key, group => group.Count());

            int totalCost = 0;

            foreach (var item in itemCounts)
            {
                var itemPrice = _items.FirstOrDefault(i => i.Name == item.Key)?.Price ?? 0;
                switch (item.Key)
                {
                    
                    case "Apple":
                        totalCost += item.Value * itemPrice;
                        break;
                    case "Banana":
                        totalCost += item.Value * itemPrice;
                        break;
                    case "Melon":
                        totalCost += (item.Value / 2 + item.Value % 2) * itemPrice;
                        break;
                    case "Lime":
                        totalCost += (item.Value / 3 * 2 + item.Value % 3) * itemPrice;
                        break;
                }
            }

            return totalCost;
        }
    }
}
