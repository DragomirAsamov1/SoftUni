using System;
using System.Linq;

namespace Jagged_ArrayModification {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++) {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < numbers.Length; col++) {
                    matrix[row, col] = numbers[col];
                }
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END") {
                string[] tokens = command.Split(' ');
                string operation = tokens[0];
                int atRow = int.Parse(tokens[1]);
                int atCol = int.Parse(tokens[2]);
                int num = int.Parse(tokens[3]);
                
                if (atRow >= 0 && atRow < matrix.GetLength(0) && atCol >= 0 && atCol < matrix.GetLength(1)) {
                    if (operation == "Add") {

                        matrix[atRow, atCol] += num;

                    } else if(operation == "Subtract") {

                        matrix[atRow, atCol] -= num;

                    }
                } else {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++) {
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
