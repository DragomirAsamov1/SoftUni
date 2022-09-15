using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing {
    public class Car {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(int kilometers) {
            if (FuelAmount >= FuelConsumptionPerKilometer * kilometers) {
                FuelAmount -= FuelConsumptionPerKilometer * kilometers;
                TravelledDistance += kilometers;
            } else {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
