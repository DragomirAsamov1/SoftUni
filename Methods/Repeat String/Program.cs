using System;
using System.Linq;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(input, count);
        }
        static void RepeatString(string input, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(input);
            }
            Console.WriteLine(result);
        }
    }
}
