using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories {
    public class Dough {
        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double> {
            {"white", 1.5 },
            {"wholegrain", 1.0 },
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.1 }
        };

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTexhnique, int weight) {
            FlourType = flourType;
            BakingTechnique = bakingTexhnique;
            Weight = weight;
        }

        public string FlourType {
            get => flourType;
            set { 
                if (!modifiers.ContainsKey(value.ToLower())) {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value; 
            }
        }

        public string BakingTechnique {
            get => bakingTechnique;
            set {
                if (!modifiers.ContainsKey(value.ToLower())) {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value; 
            }
        }

        public int Weight {
            get => weight;
            private set {
                if (value < 1 || value > 200) {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double Calories => 2 * weight * modifiers[flourType.ToLower()] * modifiers[bakingTechnique.ToLower()];


    }
}
