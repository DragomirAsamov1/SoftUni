using System;
using System.Linq;

namespace DiagonalDifference {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++) {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < numbers.Length; col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < n; i++) {
                firstSum += matrix[i, i];
                secondSum += matrix[i, n - i - 1];
            }

            Console.WriteLine(Math.Abs(firstSum-secondSum));
        }
    }
}
