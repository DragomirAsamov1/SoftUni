using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles {
    public abstract class Vehicle : IVehicle {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity) {
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public double FuelQuantity {
            get => fuelQuantity;
            private set {
                if (value > TankCapacity) {
                    fuelQuantity = 0;
                } else {
                    fuelQuantity = value;
                }

            }
        }
        public virtual double FuelConsumption { get; protected set; }
        public double TankCapacity { get; }

        public bool IsEmpty { get; set; }

        public string Drive(double distance) {
            if (distance * FuelConsumption >= FuelQuantity) {

                return $"{GetType().Name} needs refueling";
            }
            FuelQuantity -= distance * FuelConsumption;
            return $"{GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters) {
            if (liters <= 0) {
                throw new ArgumentException("Fuel must be a positive number");

            }
            if (FuelQuantity + liters > TankCapacity) {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }
            FuelQuantity += liters;
        }

        public override string ToString() {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
