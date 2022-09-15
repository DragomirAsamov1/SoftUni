using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogueObjectAndClasses {
    internal class Program {
        static void Main(string[] args) {
            List<Vehicle> vehicleCatalogue = new List<Vehicle>();

            while (true) {
                string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "End") {
                    break;
                }

                string type = inputTokens[0];
                string model = inputTokens[1];
                string color = inputTokens[2];
                int horsepower = int.Parse(inputTokens[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, horsepower);
                vehicleCatalogue.Add(currentVehicle);
            }

            while (true) {
                string model = Console.ReadLine();

                if (model == "Close the Catalogue") {
                    break;
                }

                Console.WriteLine(vehicleCatalogue.Find(x => x.Model == model));
            }

            List<Vehicle> onlyCars = vehicleCatalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = vehicleCatalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (Vehicle car in onlyCars) {
                totalCarsHorsepower += car.Horsepower;
            }

            foreach (Vehicle truck in onlyTrucks) {
                totalTrucksHorsepower += truck.Horsepower;
            }

            
            if (onlyCars.Count > 0) {
                double averageCarHorsepower = totalCarsHorsepower / onlyCars.Count;
                Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:f2}.");
            } else {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0) {
                double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            } else {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            
        }
    }
}
