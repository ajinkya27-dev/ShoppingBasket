using ShoppingBasket.Services;

var basket = new List<string> { "Apple", "Apple", "Banana", "Melon", "Melon", "Lime", "Lime", "Lime" };
var basketService = new BasketService();
var totalCost = basketService.CalculateTotalCost(basket);
Console.WriteLine($"Total cost: {totalCost}p");
