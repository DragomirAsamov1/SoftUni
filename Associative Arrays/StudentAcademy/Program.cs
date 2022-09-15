using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++) {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(student)) {
                    grades.Add(student, new List<double>() {grade});
                } else {
                    grades[student].Add(grade);
                }
            }

            Dictionary <string, double> sortedGrades = new Dictionary<string, double>();

            foreach (var item in grades) {
                sortedGrades.Add(item.Key, item.Value.Average());
            }

            foreach (var item in sortedGrades.Where(x => x.Value >= 4.50)) {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
