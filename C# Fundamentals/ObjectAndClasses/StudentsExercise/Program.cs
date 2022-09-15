using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsExercise {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student(input[0], input[1], double.Parse(input[2]));

                students.Add(student);

            }

            List<Student> orderedStudents = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, orderedStudents));
        }
    }
}
