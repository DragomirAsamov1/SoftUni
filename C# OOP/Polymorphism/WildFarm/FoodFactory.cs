using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public static class FoodFactory {
        public static IFood CreateFood(string[] foodInfo) {
            IFood food = null;

            string foodType = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            if (foodType == "Vegetable") {
                food = new Vegetable(quantity);
            } else if (foodType == "Fruit") {
                food = new Fruit(quantity);
            } else if (foodType == "Meat") {
                food = new Meat(quantity);
            } else if (foodType == "Seeds") {
                food = new Seeds(quantity);
            }

            return food;
        }
    }
}
