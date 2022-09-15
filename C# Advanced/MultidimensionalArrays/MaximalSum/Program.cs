using System;
using System.Linq;

namespace MaximalSum {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++) {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            int bestSum = int.MinValue;
            int bestRowIndex = int.MinValue;
            int bestColIndex = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++) {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++) {

                    int tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (tempSum > bestSum) {
                        bestSum = tempSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            for (int row = bestRowIndex; row < bestRowIndex+3; row++) {
                for (int col = bestColIndex; col < bestColIndex + 3; col++) {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
