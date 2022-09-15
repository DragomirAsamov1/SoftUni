using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public class Tiger : Feline {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) {
        }
        public override void Eat(IFood food) {
            if (food is Meat) {
                BaseEat(1.00, food.Quantity);
            } else {
                InvalidOperations.ThrowExceptionForInvalidFood(GetType().Name, food.GetType().Name);
            }
        }

        public override string ProduceSound() {
            return "ROAR!!!";
        }
    }
}
