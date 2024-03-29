﻿using P03.Detail_Printer;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<IEmployee> employees;

        public DetailsPrinter(IList<IEmployee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (IEmployee employee in this.employees)
            {
                Console.WriteLine(employee.Name);

                if (employee.GetType().Name == "Manager") {
                    Console.WriteLine(string.Join(Environment.NewLine, ((Manager)employee).Documents));
                }
            }
        }
    }
}
