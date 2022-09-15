using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding {
    public class StartUp {
        static void Main(string[] args) {
            List<IHero> heroes = new List<IHero>(); 
            int n = int.Parse(Console.ReadLine());

            while (heroes.Count != n) {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                Factory factory = new Factory();
                try {
                    IHero hero = factory.ProduceHero(name, type);
                    heroes.Add(hero);
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (IHero hero in heroes) {
                Console.WriteLine(hero.CastAbility());
            }

            if (bossPower <= heroes.Select(x => x.Power).ToArray().Sum()) {
                Console.WriteLine("Victory!");
            } else {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
