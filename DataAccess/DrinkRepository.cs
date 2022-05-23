using RestaurantSystem.Business;
using System.Collections.Generic;

namespace RestaurantSystem
{
    public class DrinkRepository
    {
        public List<Drink> drinkList;

        public  DrinkRepository()
        {
            drinkList = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            drinkList.Add(drink);
        }
    }
}
