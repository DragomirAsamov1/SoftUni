using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories {
    public class Topping {
        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double> {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 },
        };

        private string name;
        private int weight;

        public Topping(string name, int weight) {
            Name = name;
            Weight = weight;
        }
        public string Name {
            get => name;
            private set {
                if (!modifiers.ContainsKey(value.ToLower())) {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                name = value;
            }
        }
        public int Weight {
            get => weight;
            private set {
                if (value < 1 || value > 50) {
                    throw new ArgumentException($"{Name} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public double Calories => Weight * 2 * modifiers[Name.ToLower()];

    }
}
