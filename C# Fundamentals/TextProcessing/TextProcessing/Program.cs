using System;
using System.Linq;

namespace TextProcessing {
    internal class Program {
        static void Main(string[] args) {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end") {
                string result = new string(input.Reverse().ToArray());
                Console.WriteLine(input + " = " + result);
            }
        }
    }
}
