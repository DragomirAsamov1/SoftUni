using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!students.ContainsKey(input[0])) {
                    students.Add(input[0], new List<decimal>());
                }
                students[input[0]].Add(decimal.Parse(input[1]));
                
            }

            foreach (KeyValuePair<string, List<decimal>> student in students) {
                Console.Write($"{student.Key} -> ");
                foreach (decimal grade in student.Value) {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
