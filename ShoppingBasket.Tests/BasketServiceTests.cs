using ShoppingBasket.Services;

namespace ShoppingBasket.Tests
{
    public class BasketServiceTests
    {
        [Fact]
        public void CalculateTotalCost_ShouldReturnCorrectTotal_ForGivenBasket()
        {
            // Arrange
            var basket = new List<string> { "Apple", "Apple", "Banana", "Melon", "Melon", "Lime", "Lime", "Lime" };
            var basketService = new BasketService();

            // Act
            var totalCost = basketService.CalculateTotalCost(basket);

            // Assert
            Assert.Equal(170, totalCost);
        }

        [Fact]
        public void CalculateTotalCost_ShouldApplyMelonOffer()
        {
            // Arrange
            var basket = new List<string> { "Melon", "Melon" };
            var basketService = new BasketService();

            // Act
            var totalCost = basketService.CalculateTotalCost(basket);

            // Assert
            Assert.Equal(50, totalCost);
        }

        [Fact]
        public void CalculateTotalCost_ShouldApplyLimeOffer()
        {
            // Arrange
            var basket = new List<string> { "Lime", "Lime", "Lime" };
            var basketService = new BasketService();

            // Act
            var totalCost = basketService.CalculateTotalCost(basket);

            // Assert
            Assert.Equal(30, totalCost);
        }
    }
}