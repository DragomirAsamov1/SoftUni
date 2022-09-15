using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator {
    internal class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            //2 + 5 + 10 - 2 - 1

            Stack<string> numbers = new Stack<string>(input.Reverse());

            while (numbers.Count > 1) {
                int firstNum = int.Parse(numbers.Pop());
                string sign = numbers.Pop();
                int secondNum = int.Parse(numbers.Pop());

                if (sign == "+") {
                    numbers.Push((firstNum + secondNum).ToString());
                } else {
                    numbers.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(numbers.Pop());
        }
    }
}
