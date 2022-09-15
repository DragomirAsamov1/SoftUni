using System;
using System.Collections.Generic;

namespace TrafficJam {
    internal class Program {
        static void Main(string[] args) {
            int passedCars = int.Parse(Console.ReadLine());

            string car = string.Empty;

            Queue<string> cars = new Queue<string>();

            int counter = 0;

            while ((car = Console.ReadLine()) != "end") {
                if (car == "green") {
                    for (int i = 0; i < passedCars; i++) {
                        if (cars.Count > 0) {
                            Console.WriteLine(cars.Dequeue() + " passed!");
                            counter++;
                        }
                    }                        
                } else {
                    cars.Enqueue(car);
                }
            }

            Console.WriteLine("{0} cars passed the crossroads.", counter);
        }
    }
}
