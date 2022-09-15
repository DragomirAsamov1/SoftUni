using System;
using System.Linq;

namespace SumMatrixElements {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            int sum = 0;

            for (int row = 0; row < input[0]; row++) {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++) {
                    matrix[row, col] = numbers[col];
                    sum += numbers[col];
                }
            }
            Console.WriteLine(input[0] + "\n" + input[1]);
            Console.WriteLine(sum);
        }
    }
}
