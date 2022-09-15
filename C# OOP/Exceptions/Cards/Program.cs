using System;
using System.Collections.Generic;

namespace Cards {
    public class Program {
        static void Main(string[] args) {
            List<Card> cards = new List<Card>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++) {
                string[] tokens = input[i].Split(' ');
                try {
                    Card card = CreateCard(tokens[0], tokens[1]);
                    cards.Add(card);
                } catch (ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Card card in cards) {
                Console.Write(card);
            }
        }

        static Card CreateCard(string face, string suit) {
            return new Card(face, suit);
        }
    }
}
