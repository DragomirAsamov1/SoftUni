using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOfCards {
    internal class Program {

        static void Main(string[] args) {
            List<string> cards = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++) {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0]) {
                    case "Add":
                        Add(cards, command[1]);
                        break;
                    case "Remove":
                        Remove(cards, command[1]);
                        break;
                    case "Remove At":
                        RemoveAt(cards, int.Parse(command[1]));
                        break;
                    case "Insert":
                        Insert(cards, int.Parse(command[1]), command[2]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", cards));
        }

        static void Add(List<string> cards, string cardName) {
            if (!cards.Contains(cardName)) {
                cards.Add(cardName);

                Console.WriteLine("Card successfully added");
            } else {
                Console.WriteLine("Card is already in the deck");
            }
        }

        static void Remove(List<string> cards, string cardName) {
            if (cards.Contains(cardName)) {
                cards.Remove(cardName);
                Console.WriteLine("Card successfully removed");
            } else {
                Console.WriteLine("Card not found");
            }
        }

        static void RemoveAt(List<string> cards, int index) {
            if (index > cards.Count || index < 0) {
                Console.WriteLine("Index out of range");
            } else {
                cards.RemoveAt(index);
                Console.WriteLine("Card successfully removed");
            }
        }

        static void Insert(List<string> cards, int index, string cardName) {
            if (index > cards.Count || index < 0) {
                Console.WriteLine("Index out of range");
            } else {
                if (!cards.Contains(cardName)) {
                    cards.Insert(index, cardName);
                    Console.WriteLine("Card successfully added");
                } else {
                    Console.WriteLine("Card is already added");
                }

            }
        }
    }
}
