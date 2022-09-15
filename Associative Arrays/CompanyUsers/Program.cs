using System;
using System.Collections.Generic;

namespace CompanyUsers {
    internal class Program {
        static void Main(string[] args) {

            string input = Console.ReadLine();

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (input != "End") {
                string[] command = input.Split(" -> ");

                string company = command[0];
                string employee = command[1];

                if (users.ContainsKey(company)) {
                    if (!users[company].Contains(employee)) {
                        users[company].Add(employee);
                    }
                } else {
                    users.Add(company, new List<string> { employee });
                }

                input = Console.ReadLine();
            }

            foreach (var company in users) {
                Console.WriteLine(company.Key);
                foreach (var user in company.Value) {
                    Console.WriteLine("-- {0}", user);
                }
            }
        }
    }
}
