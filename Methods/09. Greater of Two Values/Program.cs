using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeVariable = Console.ReadLine();

            switch (typeVariable)
            {
                case "int": 
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt)); break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar)); break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString,secondString)); break;
                default:
                    break;
            }
        }
        static int GetMax(int firstInt, int secondInt)
        {
            return Math.Max(firstInt, secondInt);
        }
        static char GetMax(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
        }
        static string GetMax(string firstString, string secondString)
        {
            int comparison = firstString.CompareTo(secondString);
            if (comparison>0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
