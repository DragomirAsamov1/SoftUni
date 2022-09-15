using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public class Cat : Feline {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) {
        }

        public override void Eat(IFood food) {
            if (food is Vegetable || food is Meat) {
                BaseEat(0.30, food.Quantity);
            } else {
                InvalidOperations.ThrowExceptionForInvalidFood(GetType().Name, food.GetType().Name);
            }
        }

        public override string ProduceSound() {
            return "Meow";
        }
    }
}
