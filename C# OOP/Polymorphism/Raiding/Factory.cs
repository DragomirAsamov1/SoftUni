using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding {
    public class Factory {
        public Hero ProduceHero(string name, string type) {
            Hero hero = null;

            if (type == HeroType.Druid.ToString()) {
                hero = new Druid(name);
            } else if (type == HeroType.Warrior.ToString()) {
                hero = new Warrior(name);
            } else if (type == HeroType.Rogue.ToString()) {
                hero = new Rogue(name);
            } else if (type == HeroType.Paladin.ToString()) {
                hero = new Paladin(name);
            } else {
                throw new ArgumentException("Invalid Hero!");
            }
            return hero;
        }
    }
}
