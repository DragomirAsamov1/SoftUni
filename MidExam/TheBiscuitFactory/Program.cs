using System;

namespace TheBiscuitFactory {
    internal class Program {
        static void Main(string[] args) {

            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            long productionOfCompetition = long.Parse(Console.ReadLine());

            int percentOfProduction = 10 * (int)Math.Floor((biscuitsPerDay * workers) * 0.75);

            int countBiscuits = (biscuitsPerDay * workers) * 20 + percentOfProduction;

            Console.WriteLine($"You have produced {countBiscuits} biscuits for the past month.");

            double difference = countBiscuits - productionOfCompetition;
            double percentDiff = Math.Abs(difference / productionOfCompetition * 100);

            if (difference < 0) {
                Console.WriteLine($"You produce {percentDiff:f2} percent less biscuits.");
            } else {
                Console.WriteLine($"You produce {percentDiff:f2} percent more biscuits.");
            }


        }
    }
}
