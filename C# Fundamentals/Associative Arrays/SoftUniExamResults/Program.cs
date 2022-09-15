using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults {
    internal class Program {
        static void Main(string[] args) {
            string command = string.Empty;

            Dictionary<string, int> studentsByPoint = new Dictionary<string, int>();
            Dictionary<string, int> coursesBySubmissions = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "exam finished") {
                string[] parts = command.Split("-");

                string username = parts[0];
                string language = parts[1];

                if (language == "banned") {
                    if (studentsByPoint.ContainsKey(username)) {
                        studentsByPoint.Remove(username);
                    }
                    continue;
                }

                int points = int.Parse(parts[2]);

                if (!coursesBySubmissions.ContainsKey(language)) {
                    coursesBySubmissions.Add(language, 0);
                }
                coursesBySubmissions[language]++;

                if (studentsByPoint.ContainsKey(username)) {
                    if (studentsByPoint[username] < points) {
                        studentsByPoint[username] = points;
                    }
                } else {
                    studentsByPoint.Add(username, points);
                }
            }

            Console.WriteLine("Results:");

            foreach (var item in studentsByPoint.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in coursesBySubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
