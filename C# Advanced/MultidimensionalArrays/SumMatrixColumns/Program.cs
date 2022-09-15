using System;
using System.Linq;

namespace SumMatrixColumns {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[] sums = new int[input[1]];

            int [,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++) {

                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < input[1]; col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int col = 0; col < input[1]; col++) {

                int tempSum = 0;

                for (int row = 0; row < input[0]; row++) {
                    tempSum += matrix[row, col];
                }

                sums[col] = tempSum;
            }

            foreach (int sum in sums) {
                Console.WriteLine(sum);
            }
        }
    }
}
