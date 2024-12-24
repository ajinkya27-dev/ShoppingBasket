using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Services
{
    public class BasketService
    {
        private readonly Dictionary<string, int> _prices = new Dictionary<string, int>
        {
            { "Apple", 35 },
            { "Banana", 20 },
            { "Melon", 50 },
            { "Lime", 15 }
        };

        public int CalculateTotalCost(List<string> basket)
        {
            var itemCounts = basket.GroupBy(item => item)
                                   .ToDictionary(group => group.Key, group => group.Count());

            int totalCost = 0;

            foreach (var item in itemCounts)
            {
                switch (item.Key)
                {
                    case "Apple":
                        totalCost += item.Value * _prices[item.Key];
                        break;
                    case "Banana":
                        totalCost += item.Value * _prices[item.Key];
                        break;
                    case "Melon":
                        totalCost += (item.Value / 2 + item.Value % 2) * _prices[item.Key];
                        break;
                    case "Lime":
                        totalCost += (item.Value / 3 * 2 + item.Value % 3) * _prices[item.Key];
                        break;
                }
            }

            return totalCost;
        }
    }
}
