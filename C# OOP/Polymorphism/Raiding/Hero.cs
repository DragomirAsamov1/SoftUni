using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding {
    public abstract class Hero : IHero {
        public Hero(string name) {
            Name = name;
        }

        public string Name { get; private set; } 

        public abstract int Power {get; }

        public abstract string CastAbility();
    }
}
