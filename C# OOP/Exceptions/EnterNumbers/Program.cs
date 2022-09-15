using System;
using System.Linq;

namespace EnterNumbers {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = new int[10];
            int counter = 0;
            int currentMaxNum = 1;

            

            while (counter < 10) {
                try {
                    
                    int num = int.Parse(Console.ReadLine());
                    if (num <= numbers.Max() || num < 2 || num > 99) {
                        throw new Exception($"Your number is not in the range({currentMaxNum} - 100)");
                    }
                    numbers[counter] = num;
                    currentMaxNum = num;
                    counter++;
                } catch (FormatException) {
                    Console.WriteLine("Invalid number!");
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));

        }
    }
}
