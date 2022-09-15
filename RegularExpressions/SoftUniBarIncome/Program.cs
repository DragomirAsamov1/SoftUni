using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniBarIncome {
    internal class Program {
        static void Main(string[] args) {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

            string input = string.Empty;

            List<Order> orders = new List<Order>();

            while ((input = Console.ReadLine()) != "end of shift") {

                if (Regex.IsMatch(input, pattern)) {

                    Match match = Regex.Match(input, pattern);
                    string customerName = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    decimal totalPrice = int.Parse(match.Groups["count"].Value) * decimal.Parse(match.Groups["price"].Value);

                    Order order = new Order(customerName, product, totalPrice);

                    orders.Add(order);
                }
            }

            foreach (Order order in orders) {
                Console.WriteLine(order);
            }

            Console.WriteLine($"Total income: {orders.Sum(x => x.TotalPrice):f2}");
        }
    }
}
