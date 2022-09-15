using System;
using System.Text;

namespace ReplaceRepeatingChars {
    internal class Program {
        static void Main(string[] args) {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length - 1; i++) {
                if (text[i] != text[i+1]) {
                    sb.Append(text[i]);
                }
            }
            if (text.Length > 0) {
                sb.Append(text[text.Length - 1]);
            }
            Console.WriteLine(sb);
        }
    }
}
