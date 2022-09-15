using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsExercise {
    internal class Student {

        public Student(string firstName, string lastName, double grade) {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString() {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
