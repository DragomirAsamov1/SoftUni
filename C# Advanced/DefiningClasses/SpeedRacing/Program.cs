using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++) {

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerOneKilometer = double.Parse(input[2]);
                Car car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKilometer = fuelConsumptionPerOneKilometer;

                cars.Add(car);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End") {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = tokens[1];
                int distance = int.Parse(tokens[2]);

                Car car = cars.Where(x => x.Model == carModel).FirstOrDefault();
                car.Drive(distance);
                
            }

            foreach (Car car in cars) {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance} ");
            }
        }
    }
}
