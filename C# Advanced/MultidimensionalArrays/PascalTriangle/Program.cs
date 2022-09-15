using System;
using System.Linq;

namespace PascalTriangle {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            long[][] jaggedMatrix = new long[n][];

            jaggedMatrix[0] = new long[] { 1 };

            for (int row = 1; row < n; row++) {
                jaggedMatrix[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++) {
                    long sum = 0;

                    if (row - 1 >= 0 && col < jaggedMatrix[row-1].Length) {
                        sum += jaggedMatrix[row - 1][col];
                    }
                    if (row - 1 >= 0 && col - 1 >= 0) {
                        sum += jaggedMatrix[row - 1][col - 1];
                    }
                    if (sum == 0) {
                        sum = 1;
                    }
                    jaggedMatrix[row][col] = sum;
                }

            }

            for (int row = 0; row < jaggedMatrix.Length; row++) {
                for (int col = 0; col < jaggedMatrix[row].Length; col++) {
                    Console.Write(jaggedMatrix[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
