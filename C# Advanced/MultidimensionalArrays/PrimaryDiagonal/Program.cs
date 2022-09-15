using System;
using System.Linq;

namespace PrimaryDiagonal {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++) {

                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int i = 0; i < n; i++) {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
