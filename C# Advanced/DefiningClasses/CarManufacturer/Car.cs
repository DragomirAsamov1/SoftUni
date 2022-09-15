using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer {
    public class Car {

        public Car() {
            string Make = "VW";
            string Model = "Golf";
            int Year = 2025;
            double FuelQuantity = 200;
            double FuelConsumpion = 10;
        }

        public Car(string make, string model, int year)
            : this() {
            Make = make;
            Model = model;
            Year = year;
            double FuelQuantity = 200;
            double FuelConsumpion = 10;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year) {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, List<Tire> tires)
            :this(make, model, year, fuelQuantity, fuelConsumption){
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public List<Tire> Tires { get; set; }

        public void Drive(double distance) {
            if (FuelQuantity > (FuelConsumption * (distance/100))) {
                FuelQuantity -= FuelConsumption * (distance/100);
            } else {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI() {
            return $"{Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}L";
        }

    }
}
