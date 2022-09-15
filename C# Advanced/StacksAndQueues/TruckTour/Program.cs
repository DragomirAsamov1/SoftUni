using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour {
    internal class Program {
        static void Main(string[] args) {
            int petrolPumps = int.Parse(Console.ReadLine());

            int petrol = 0;

            int bestIndex = 0;

            Queue<int> fuels = new Queue<int>();
            Queue<int> distances = new Queue<int>();

            for (int i = 0; i < petrolPumps; i++) {
                string[] values = Console.ReadLine().Split(' ');
              
                fuels.Enqueue(int.Parse(values[0]));
                distances.Enqueue(int.Parse(values[1]));
            }
            while (bestIndex < petrolPumps) {
                for (int i = 0; i < petrolPumps; i++) {
                    int fuel = fuels.Dequeue();
                    int distance = distances.Dequeue();

                    fuels.Enqueue(fuel);
                    distances.Enqueue(distance);

                    petrol += fuel;

                    if (petrol > distance) {
                        petrol -= distance;
                        continue;
                    } else {
                        petrol = 0;
                        break;
                    }
                }


                bestIndex++;
            }
            
        }  
    }
}
