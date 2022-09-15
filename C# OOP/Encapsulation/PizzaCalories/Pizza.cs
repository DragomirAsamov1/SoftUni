using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories {
    public class Pizza {
        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough) {
            Name = name;
            toppings = new List<Topping>();
            Dough = dough;
        }

        public string Name {
            get => name;
            private set {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15) {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols");
                }
                name = value;
            }
        }
        public Dough Dough { get; private set; }

        public double Calories => Dough.Calories + toppings.Sum(x => x.Calories);

        public void AddTopping(Topping topping) {
            if (toppings.Count > 9) {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);

        }

    }
}
