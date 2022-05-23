using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantSystem.Business;

namespace RestaurantSystem.Tests
{
    [TestClass]
    public class FoodTest
    {
        [TestMethod]
        public void CreateFood_DataValid_FoodCreated()
        {
            double price = 10;

            Food food = new Food(price);

            Assert.AreEqual(food.Price, price);
        }
    }
}
