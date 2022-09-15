using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true) {
                string[] input = Console.ReadLine().Split(" : ");

                if (input[0].Contains("end")) {
                    break;
                }

                string course = input[0];
                string studentName = input[1];

                if (courses.ContainsKey(course)) {
                    courses[course].Add(studentName);
                } else {
                    courses.Add(course, new List<string>() { studentName});
                }
            }

            foreach (var course in courses) {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value) {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
