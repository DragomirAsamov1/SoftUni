﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl {
    public class Pet : IBirthable {
        public Pet(string name, string birthday) {
            Name = name;
            Birthday = birthday;
        }
        public string Name { get; private set; }
        public string Birthday { get; private set; }
    }
}
