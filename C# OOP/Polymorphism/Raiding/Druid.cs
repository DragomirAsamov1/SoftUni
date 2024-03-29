﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding {
    public class Druid : Hero {
        public Druid(string name) : base(name) {
        }

        public override int Power => 80;

        public override string CastAbility() {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
