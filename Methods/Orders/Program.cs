using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            
            double price = Orders(product, count);
            Console.WriteLine($"{price:f2}");
        }
        static double Orders (string product, int count)
        {
            double price = 0.0;
            switch (product)
            {
                case "coffee": price = count * 1.50; break;
                case "water": price = count * 1.00; break;
                case "coke": price = count * 1.40; break;
                case "snacks": price = count * 2.00; break;
                default:
                    break;
            }
            return price;
        }
    }
}
