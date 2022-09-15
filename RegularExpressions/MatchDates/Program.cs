using System;
using System.Text.RegularExpressions;

namespace MatchDates {
    internal class Program {
        static void Main(string[] args) {
            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})\2(\d{4})\b";

            string dates = Console.ReadLine();

            MatchCollection datesMatches = Regex.Matches(dates, pattern);

            foreach (Match date in datesMatches) {
                string day = date.Groups[1].Value;
                string month = date.Groups[3].Value;
                string year = date.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
