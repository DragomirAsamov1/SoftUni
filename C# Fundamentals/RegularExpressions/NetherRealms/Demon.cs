using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetherRealms {
    internal class Demon {

        public Demon(string name, int health, decimal damage) {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; }
        public int Health { get; }
        public decimal Damage { get; }

        public override string ToString() {
            return $"{Name} - {Health} health, {Damage:f2} damage ";
        }
    }
}
