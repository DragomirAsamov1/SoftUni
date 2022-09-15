using System;
using System.Linq;

namespace JaggedArrayManipulator {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int [][] jaggedMatrix = new int[n][];

            for (int i = 0; i < n; i++) {
                jaggedMatrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < n-1; i++) {
                if (jaggedMatrix[i].Length == jaggedMatrix[i+1].Length) {
                    for (int j = 0; j < jaggedMatrix[i].Length; j++) {
                        jaggedMatrix[i][j] *= 2;
                    }

                    for (int j = 0; j < jaggedMatrix[i+1].Length; j++) {
                        jaggedMatrix[i + 1][j] *= 2;
                    }

                } else {
                    for (int j = 0; j < jaggedMatrix[i].Length; j++) {
                        jaggedMatrix[i][j] /= 2;
                    }

                    for (int j = 0; j < jaggedMatrix[i + 1].Length; j++) {
                        jaggedMatrix[i + 1][j] /= 2;
                    }

                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine())!= "End") {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4) {
                    if (tokens[0] == "Add" || tokens[0] == "Subtract") {
                        int row = int.Parse(tokens[1]);
                        int col = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);

                        if (row >= 0 && row < jaggedMatrix.Length) {
                            if (col >= 0 && col < jaggedMatrix[row].Length) {
                                if (tokens[0] == "Add") {
                                    jaggedMatrix[row][col] += value;
                                } else {
                                    jaggedMatrix[row][col] -= value;
                                }
                            }
                        }
                    }
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
