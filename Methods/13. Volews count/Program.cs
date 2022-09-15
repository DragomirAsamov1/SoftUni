using System;

namespace _13._Volews_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = VolewsCount(input);
            Console.WriteLine(result);
        }
        static int VolewsCount(string input)
        {
            char[] text = input.ToCharArray();
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                    case 'o':
                    case 'u':
                    case 'i':
                    case 'e': count++; break;
                    default:
                        break;
                }
            }
            return count;
        }
    }
}
