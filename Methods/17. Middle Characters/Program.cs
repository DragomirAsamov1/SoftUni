using System;

namespace _17._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string result = GetMiddleChar(word);
            Console.WriteLine(result);
        }
        static string GetMiddleChar(string word)
        {
            string result = string.Empty;

            if (word.Length % 2 !=0)
            {
                result = word[word.Length / 2].ToString();
            }
            else
            {
                result = word[word.Length / 2-1].ToString() + word[word.Length / 2].ToString();
            }
            return result;
        }
    }
}
