using System;
using System.Linq;

namespace MatrixShuffling {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] matrix = new string[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++) {
                string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END") {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string operation = tokens[0];

                if (operation != "swap" || tokens.Length != 5) {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int firstStringRow = int.Parse(tokens[1]);
                int firstStringCol = int.Parse(tokens[2]);
                int secondStringRow = int.Parse(tokens[3]);
                int secondStringCol = int.Parse(tokens[4]);

                if (firstStringRow < 0 || firstStringRow >= matrix.GetLength(0)) {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (firstStringCol < 0 || firstStringCol >= matrix.GetLength(1)) {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (secondStringRow < 0 || secondStringRow >= matrix.GetLength(0)) {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (secondStringCol < 0 || secondStringCol >= matrix.GetLength(1)) {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string tempString = matrix[secondStringRow, secondStringCol];
                matrix[secondStringRow, secondStringCol] = matrix[firstStringRow, firstStringCol];
                matrix[firstStringRow, firstStringCol] = tempString;

                for (int row = 0; row < matrix.GetLength(0); row++) {
                    for (int col = 0; col < matrix.GetLength(1); col++) {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
