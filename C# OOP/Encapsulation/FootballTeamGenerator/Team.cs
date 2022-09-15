using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator {
    public class Team {
        private string name;
        private int rating;
        private List<Player> players;
        public Team(string name) {
            Name = name;
            players = new List<Player>();
        }
        public string Name {
            get => name;
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value; 
            }
        }
        public int Rating => players.Any() ? (int)Math.Round(players.Select(x => x.Stats).Average()) : 0;

        public void Add(Player player) {
            players.Add(player);
        }

        public void Remove(string playerName) {
            Player player = players.FirstOrDefault(x => x.Name == playerName);
            if (player == null) {
                throw new ArgumentException($"Player {playerName} is not in the {this.Name} team.");
            } else {
                players.Remove(player);
            }
        }
    }
}
