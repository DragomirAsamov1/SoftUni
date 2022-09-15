using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public class Owl : Bird {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize) {
        }
        public override void Eat(IFood food) {
            if (food is Meat) {
                BaseEat(0.25, food.Quantity);
            } else {
                InvalidOperations.ThrowExceptionForInvalidFood(GetType().Name, food.GetType().Name);
            }
        }
        public override string ProduceSound() {
            return "Hoot Hoot";
        }
    }
}
