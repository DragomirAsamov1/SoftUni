using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (!departments.Any( x=> x.DepartmentName == input[2])) {
                    departments.Add(new Department(input[2]));
                }

                departments.Find(x => x.DepartmentName == input[2]).AddNewEmployee(input[0], decimal.Parse(input[1]));
            }


            Department bestDepartment = departments.OrderByDescending(x => x.TotalSalaries / x.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (Employee employee in bestDepartment.Employees.OrderByDescending(x => x.Salary)) {
                Console.WriteLine(employee);
            }
        }
    }
}
