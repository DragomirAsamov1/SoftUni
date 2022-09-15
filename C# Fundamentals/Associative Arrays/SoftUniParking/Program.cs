using System;
using System.Collections.Generic;

namespace SoftUniParking {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            string[] command = new string[] { };

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++) {
                command = Console.ReadLine().Split(' ');

                string operation = command[0];
                string personName = command[1];
                

                if (operation == "register") {

                    string plateNumber = command[2];

                    if (parking.ContainsKey(personName)) {
                        Console.WriteLine("ERROR: already registered with plate number {0}", parking[personName]);
                    } else {
                        parking.Add(personName, plateNumber);
                        Console.WriteLine($"{personName} registered {plateNumber} successfully");
                    }
                } else if (operation == "unregister") {
                    if (parking.ContainsKey(personName)) {
                        parking.Remove(personName);
                        Console.WriteLine($"{personName} unregistered successfully");
                    } else {
                        Console.WriteLine($"ERROR: user {personName} not found");
                    }
                }
            }

            foreach (var item in parking) {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
