using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData {
    public class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                List<Tire> tires = new List<Tire> {
                    new Tire(double.Parse(input[5]), int.Parse(input[6])),
                    new Tire(double.Parse(input[7]), int.Parse(input[8])),
                    new Tire(double.Parse(input[9]), int.Parse(input[10])),
                    new Tire(double.Parse(input[11]), int.Parse(input[12])),
                };

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
                
            }

            string type = Console.ReadLine();

            List<Car> filteredCars = new List<Car>();

            if (type == "fragile") {
                filteredCars = cars.Where(car => car.Tires.Select(x => x.Pressure).ToList().Average() < 1 && car.Cargo.CargoType == type).ToList();
            } else if (type == "flamable") {
                filteredCars = cars.Where(car => car.Engine.EnginePower > 250 && car.Cargo.CargoType == type).ToList();
            }

            foreach (Car car in filteredCars) {
                Console.WriteLine(car.Model);
            }

        }
    }
}
