using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony {
    public class Program {
        static void Main(string[] args) {
            IList<string> numbers = Console.ReadLine().Split(' ').ToList();
            IList<string> urls = Console.ReadLine().Split(' ').ToList();

            foreach (string number in numbers) {
                if (number.Length.Equals(7)) {
                    try {
                        ICallable phone = new StationaryPhone();
                        Console.WriteLine(phone.Call(number));
                    } catch (ArgumentException ex) {
                        Console.WriteLine(ex.Message);
                    }

                } else if (number.Length.Equals(10)) {
                    try {
                        ICallable phone = new Smartphone();
                        Console.WriteLine(phone.Call(number));
                    } catch (ArgumentException ex) {
                        Console.WriteLine(ex.Message);
                    }
                } 
            }

            foreach (string url in urls) {
                try {
                    IBrowseable phone = new Smartphone();
                    Console.WriteLine(phone.Browse(url));
                } catch (ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
