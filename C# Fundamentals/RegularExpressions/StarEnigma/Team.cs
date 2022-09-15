using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarEnigma {
    internal class Team {

        public Team(string name, int population, char attackType, int soldierCount) {
            Name = name;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }

        public string Name { get; }
        public int Population { get; }
        public char AttackType { get; }
        public int SoldierCount { get; }


    }
}
