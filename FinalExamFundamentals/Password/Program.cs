using System;
using System.Text.RegularExpressions;

namespace Password {
    public class Program {
        static void Main(string[] args) {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Complete") {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0]) {
                    case "Make":
                        string letter = password[int.Parse(tokens[2])].ToString();
                        int passwordIndex = password.IndexOf(letter);
                        password = password.Remove(passwordIndex, 1);
                        if (tokens[1] == "Upper") {
                            password = password.Insert(passwordIndex, letter.ToUpper());
                        } else if (tokens[1] == "Lower") {
                            password = password.Insert(passwordIndex, letter.ToLower());
                        }
                        Console.WriteLine(password);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        if (index >= 0 || index < password.Length) {
                            password = password.Insert(index, tokens[2]);
                        }
                        Console.WriteLine(password);
                        break;
                    case "Replace":
                        char symbol = (char)(char.Parse(tokens[1]) + int.Parse(tokens[2]));

                        password = password.Replace(char.Parse(tokens[1]), symbol);
                        Console.WriteLine(password);
                        break;

                    case "Validation":

                        string digitPattern = @"[\d]+";
                        string lowerCharPattern = @"[a-z]+";
                        string upperCharPattern = @"[A-Z]+";
                        string wordPattern = @"^[a-zA-Z\d_]+$";

                        if (password.Length < 8) {
                            Console.WriteLine("Password must be at least 8 characters long!");
                        } else if (!Regex.IsMatch(password, wordPattern)) {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                        } else if (!Regex.IsMatch(password, upperCharPattern)) {
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                        } else if (!Regex.IsMatch(password, lowerCharPattern)) {
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                        } else if (!Regex.IsMatch(password, digitPattern)) {
                            Console.WriteLine("Password must consist at least one digit!");
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
