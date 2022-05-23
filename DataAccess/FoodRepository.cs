using RestaurantSystem.Business;
using System.Collections.Generic;

namespace RestaurantSystem
{
    public class FoodRepository
    {
        public List<Food> foodList;

        public FoodRepository()
        {
            foodList = new List<Food>();
        }

        public void AddFood(Food food)
        {
            foodList.Add(food);
        }
    }
}

