using System;
using System.Linq;

namespace SquareWithMaximumSum {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            int biggestSum = int.MinValue;
            int bestRowIndex = int.MinValue;
            int bestColIndex = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++) {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < numbers.Length; col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++) {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++) {

                    int tempSum = matrix[row, col] + matrix[row+1, col] + matrix[row, col+1] + matrix[row+1, col+1];
                    if (tempSum > biggestSum) {
                        biggestSum = tempSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[bestRowIndex, bestColIndex]} {matrix[bestRowIndex, bestColIndex+1]}");
            Console.WriteLine($"{matrix[bestRowIndex+1, bestColIndex]} {matrix[bestRowIndex+1, bestColIndex+1]}");
            Console.WriteLine(biggestSum);
        }
    }
}
