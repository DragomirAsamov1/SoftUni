using System;
using System.Linq;

namespace SquaresInMatrix {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++) {
                char[] letters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++) {
                    matrix[row, col] = letters[col];
                }
            }

            int coincidence = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++) {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++) {
                    char firstChar = matrix[row, col];
                    char secondChar = matrix[row, col + 1];
                    char thirdChar = matrix[row + 1, col];
                    char fourthChar = matrix[row + 1, col + 1];
                    if (firstChar == secondChar && firstChar == thirdChar && firstChar == fourthChar) {
                        coincidence++;
                    }
                }
            }

            Console.WriteLine(coincidence);
        }
    }
}
