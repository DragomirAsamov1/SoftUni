using P03.Detail_Printer;
using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class Program
    {
        public static void Main()
        {

            IEmployee employee = new Employee("Kolio");
            DetailsPrinter printer = new DetailsPrinter(new List<IEmployee> { employee });
            printer.PrintDetails();
        }
    }
}
