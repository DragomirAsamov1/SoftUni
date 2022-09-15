using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards {
    public class Card {
        private IReadOnlyCollection<string> AllowedSuits => new string[] {"S", "H", "D", "C"};
        private IReadOnlyCollection<string> AllowedFaces => new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        private string face;
        private string suit;
        public string Face {
            get => face;
            private set {
                if (!AllowedFaces.Contains(value)) {
                    throw new ArgumentException("Invalid card!");
                }

                face = value;
            }
        }
        public string Suit {
            get => suit;
            set {
                if (!AllowedSuits.Contains(value)) {
                    throw new ArgumentException("Invalid card!");
                }

                suit = value;
            }
        }

        public Card(string face, string suit) {
            Face = face;
            Suit = suit;
        }

        public override string ToString() {
            char ch = '\0';
            switch (Suit) {
                case "S": ch = '\u2660';
                    break;
                case "H":
                    ch = '\u2665';
                    break;
                case "D":
                    ch = '\u2666';
                    break;
                case "C":
                    ch = '\u2663';
                    break;
                default:
                    break;
            }
            return $"[{Face}{ch}]";
        }
    }
}
