using System;

namespace DateModifier {
    public class Program {
        static void Main(string[] args) {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier days = new DateModifier();

            Console.WriteLine(days.DaysDifference(firstDate, secondDate));
        }
    }
}
