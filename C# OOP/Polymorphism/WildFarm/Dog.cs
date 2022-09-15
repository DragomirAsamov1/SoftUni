using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public class Dog : Mammal {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion) {
        }

        public override void Eat(IFood food) {
            if (food is Meat) {
                BaseEat(0.40, food.Quantity);
            } else {
                InvalidOperations.ThrowExceptionForInvalidFood(GetType().Name, food.GetType().Name);
            }
        }

        public override string ProduceSound() {
            return "Woof";
        }
    }
}
