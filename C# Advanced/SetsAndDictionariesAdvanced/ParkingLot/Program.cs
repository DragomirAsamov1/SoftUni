using System;
using System.Collections.Generic;

namespace ParkingLot {
    internal class Program {
        static void Main(string[] args) {
            string command = string.Empty;

            HashSet<string> parking = new HashSet<string>();

            while(true) {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string action = input[0];

                if (action == "END") {
                    break;
                }
                string regNumber = input[1];

                if (action == "IN") {
                    parking.Add(regNumber);
                } else if(action == "OUT") {
                    parking.Remove(regNumber);
                }
            }

            if (parking.Count == 0) {
                Console.WriteLine("Parking Lot is Empty");

            } else {
                foreach (string regNumber in parking) {
                    Console.WriteLine(regNumber);
                }
            }
        }
    }
}
