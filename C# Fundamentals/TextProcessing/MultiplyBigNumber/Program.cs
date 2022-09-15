using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine(decimal.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()));

            //-------------------------------------------------------------------------------------

            StringBuilder sb = new StringBuilder();

            string longNum = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());

            int temp = 0;

            if (num == 0 || longNum == string.Empty) {
                Console.WriteLine(0);
                return;
            }

            foreach (char ch in longNum.Reverse()) {
                int digit = int.Parse(ch.ToString());

                int result = digit * num + temp;

                int restDigit = result % 10;
                temp = result / 10;

                sb.Insert(0, restDigit);
            }

            if (temp > 0) {
                sb.Insert(0, temp);
            }
            Console.WriteLine(sb);
        }
    }
}
