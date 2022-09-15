using System;
using System.Text;

namespace _14._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            string result = BetweenSymbols(start, end);
            Console.WriteLine(result);
        }
        static string BetweenSymbols(char start, char end)
        {
            StringBuilder sb = new StringBuilder();
            if (start>end)
            {
                char mediator = end;
                end = start;
                start = mediator;
            }
            for (int i = start+1; i < end; i++)
            {
                sb.Append((char)i + " ");
            }
            string result = sb.ToString();
            return result;
        }
    }
}
