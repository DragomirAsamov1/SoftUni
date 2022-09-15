using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer {
    public class Program {
        static void Main(string[] args) {

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Tournament") {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = new Trainer(trainerName);
                

                if (!trainers.ContainsKey(trainerName)) {

                    trainers.Add(trainerName, trainer);
                }
                trainers[trainerName].Pokemons.Add(pokemon);

            }

            while ((input = Console.ReadLine()) != "End") {
                foreach (Trainer trainer in trainers.Values) {
                    if (trainer.Pokemons.Any(x => x.Element == input)) {
                        trainer.Badges++;
                    } else {
                        foreach (Pokemon pokemon in trainer.Pokemons) {
                            pokemon.Health -= 10;
                        }
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values) {
                for (int i = 0; i < trainer.Pokemons.Count; i++) {
                    if (trainer.Pokemons[i].Health <= 0) {
                        trainer.Pokemons.Remove(trainer.Pokemons[i]);
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(x => x.Badges)) {
                Console.WriteLine(trainer);
            }
        }
    }
}
