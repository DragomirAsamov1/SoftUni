using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant {
    public class Beverage : Product {
        public Beverage(string name, decimal price, double milimeters) : base(name, price) {
            Mililiters = milimeters;
        }

        public double Mililiters { get; set; }


    }
}
