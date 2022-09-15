using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed {
    public class Vehicle {

        public const double DefaultFuelConsumtion = 1.25;

        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel) {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption => DefaultFuelConsumtion;
        public virtual void Drive(double kilometers) {
            if (Fuel - kilometers * FuelConsumption >= 0) {
                Fuel -= kilometers * FuelConsumption;
            }
        }
    }
}
