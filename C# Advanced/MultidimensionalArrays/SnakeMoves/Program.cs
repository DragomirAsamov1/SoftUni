using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMoves {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<List<char>> matrix = new List<List<char>>();
            string[]

            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int index = 0;
            int direction = 0;

            for (int row = 0; row < input[0]; row++) {
                for (int col = 0; col < input[1]; col++) {
                    if (index > word.Length - 1) {
                        index = 0;
                    }
                    sb.Append(word[index]);
                    index++;
                }
                matrix.Add(sb.ToString());
                
                sb.Clear();
                if (row % 2 == 1) {
                    matrix[row] = matrix[row].Reverse();
                }
            }

            foreach (string item in matrix) {
                Console.WriteLine(item);
            }
        }
    }
}
