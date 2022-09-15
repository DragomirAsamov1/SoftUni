using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree {
    public class Person {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money) {
            Name = name;
            Money = money;
            products = new List<Product>();
        }
        public string Name {
            get => name;
            private set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money { 
            get => money;
            private set {
                if (value < 0) {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public IReadOnlyCollection<Product> Products => products;

        public bool AddProduct(Product product) {
            if (Money - product.Cost < 0) {
                return false;
            }

            products.Add(product);
            Money -= product.Cost;

            return true;
        }
    }
}
