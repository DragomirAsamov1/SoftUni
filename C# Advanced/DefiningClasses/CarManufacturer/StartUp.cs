using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer {
    public class StartUp {
        static void Main(string[] args) {
            List<List<Tire>> tires = new List<List<Tire>>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string command = string.Empty;
            int tireIndex = 0;

            while ((command = Console.ReadLine()) != "No more tires") {
                string[] tireTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                tires.Add(new List<Tire>());
                
                for (int i = 0; i < tireTokens.Length/2; i++) {
                    Tire tire = new Tire(int.Parse(tireTokens[i*2]), double.Parse(tireTokens[(i*2)+1]));
                    tires[tireIndex].Add(tire);
                }
                tireIndex++;
            }

            while ((command = Console.ReadLine()) != "Engines done") {
                string[] engineTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(engineTokens[0]), double.Parse(engineTokens[1]));

                engines.Add(engine);
            }

            while ((command = Console.ReadLine()) != "Show special") {
                string[] carTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(
                    carTokens[0],
                    carTokens[1],
                    int.Parse(carTokens[2]),
                    double.Parse(carTokens[3]),
                    double.Parse(carTokens[4]),
                    engines[int.Parse(carTokens[5])],
                    tires[int.Parse(carTokens[6])]);

                cars.Add(car);
            }

            List<Car> specialCar = cars
                .Where(car => car.Year >= 2017)
                .Where(car => car.Engine.HorsePower > 330)
                .Where(car => car.Tires.Select(x => x.Pressure).ToList().Sum() >= 9.0 
                           && car.Tires.Select(x => x.Pressure).ToList().Sum() < 10.0)
                .ToList();


            foreach (Car car in specialCar) {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }

        }
    }
}
