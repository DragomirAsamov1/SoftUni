using System;

namespace SymbolInMatrix {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n,n];

            for (int row = 0; row < n; row++) {
                string input = Console.ReadLine();

                for (int col = 0; col < input.Length; col++) {
                    matrix[row, col] = input[col];
                }
            }

            char requiredLetter = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++) {
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    if (matrix[row,col] == requiredLetter) {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{requiredLetter} does not occur in the matrix");
        }
    }
}
