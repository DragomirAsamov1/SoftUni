using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm {
    public abstract class Animal: IAnimal {
        protected Animal(string name, double weight) {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract string ProduceSound();
        public abstract void Eat(IFood food);

        protected void BaseEat(double modifier, int quantity) {
            Weight +=  modifier * quantity;
            FoodEaten += quantity;
        }
    }
}
