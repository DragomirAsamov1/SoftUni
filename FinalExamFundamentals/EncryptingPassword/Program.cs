using System;
using System.Linq;

namespace EncryptingPassword {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string password = Console.ReadLine();

                Console.WriteLine(CheckPass(password));

            }
        }

        static string CheckPass(string password) {

            string falseMessage = "Try another password!";

            int startIndex = password.IndexOf('>');
            if (startIndex < 0) {
                return falseMessage;
            }
            string startString = password.Substring(0, startIndex);
            int lastIndex = password.LastIndexOf('<');

            if (lastIndex < 0) {
                return falseMessage;
            }

            string endString = password.Substring(password.Length - startIndex);

            if (startIndex >= lastIndex) {
                return falseMessage;
            }
            string actualWord = password.Substring(startIndex + 1, password.Length - startIndex - (password.Length - lastIndex + 1));


            if (startString != endString) {
                return falseMessage;
            }

            string[] tokens = actualWord.Split('|', StringSplitOptions.RemoveEmptyEntries);

            if (!tokens[0].All(x => char.IsDigit(x)) || tokens[0].Length != 3) {
                return falseMessage;
            }

            if (!tokens[1].All(x => char.IsLetter(x) && char.IsLower(x)) || tokens[0].Length != 3) {
                return falseMessage;
            }

            if (!tokens[2].All(x => char.IsLetter(x) && char.IsUpper(x)) || tokens[0].Length != 3) {
                return falseMessage;
            }

            if (tokens[3].Any(x => x == '<' || x == '>') || tokens[0].Length != 3) {
                return falseMessage;
            }

            return $"Password: {string.Join("", tokens)}";
        }
    }
}
