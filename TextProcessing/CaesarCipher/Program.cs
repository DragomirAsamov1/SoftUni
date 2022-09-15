using System;
using System.Text;

namespace CaesarCipher {
    internal class Program {
        static void Main(string[] args) {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char letter in text) {
                sb.Append((char)(letter + 3));
            }

            Console.WriteLine(sb);
        }
    }
}
