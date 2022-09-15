using System;
using System.Collections.Generic;

namespace CarSalesman {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine = new Engine(model, power);

                if (input.Length == 3) {
                    if (char.IsDigit(input[2][0])) {
                        int displacement = int.Parse(input[2]);
                        engine.Displacement = displacement;
                    } else {
                        string efficiency = input[2];
                        engine.Efficiency = efficiency;
                    }
                } else if (input.Length == 4) {
                    engine.Displacement = int.Parse(input[2]);
                    engine.Efficiency = input[3];
                }

                engines.Add(model, engine);
            }

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                Engine engine = engines[input[1]];
                Car car = new Car(model, engine);

                if (input.Length == 3) {
                    if (char.IsDigit(input[2][0])) {
                        int weight = int.Parse(input[2]);
                        car.Weight = weight;
                    } else {
                        string color = input[2];
                        car.Color = color;
                    }
                } else if (input.Length == 4) {
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                }
                cars.Add(car);
            }

            foreach (Car car in cars) {
                Console.WriteLine(car);
            }
        }
    }
}
