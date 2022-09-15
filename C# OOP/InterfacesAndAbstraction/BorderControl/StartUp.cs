using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl {
    public class StartUp {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            IList<IBuyer> buyerList = new List<IBuyer>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length == 4) {
                    buyerList.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                } else {
                    buyerList.Add(new Rebel(input[0], int.Parse(input[1])));
                }
            }

            while (true) {
                string command = Console.ReadLine();

                if (command == "End") {
                    break;
                }

                IBuyer currentBuyer = buyerList.FirstOrDefault(x => x.Name == command);

                if (currentBuyer != null) {
                    currentBuyer.BuyFood();
                }
            }

            Console.WriteLine(buyerList.Select(x => x.Food).Sum());
        }
    }
}
