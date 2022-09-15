using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public class Mouse : Mammal {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion) {
        }

        public override void Eat(IFood food) {
            if (food is Vegetable || food is Fruit) {
                BaseEat(0.10, food.Quantity);
            } else {
                InvalidOperations.ThrowExceptionForInvalidFood(GetType().Name, food.GetType().Name);
            }

        }

        public override string ProduceSound() {
            return "Squeak";
        }
    }
}
