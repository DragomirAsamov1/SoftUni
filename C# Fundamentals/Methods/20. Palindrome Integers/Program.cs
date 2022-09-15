using System;
using System.Text;

namespace _20._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                Console.WriteLine(Reversed(command));
                command = Console.ReadLine();
            }
        }
        static bool Reversed(string command)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = command.Length - 1; i >= 0; i--)
            {
                sb.Append(command[i]);
            }
            if (command == sb.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
