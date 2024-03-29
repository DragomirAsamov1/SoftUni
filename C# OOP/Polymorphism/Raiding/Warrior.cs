﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding {
    public class Warrior : Hero {
        public Warrior(string name) : base(name) {
        }

        public override int Power => 100;

        public override string CastAbility() {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
