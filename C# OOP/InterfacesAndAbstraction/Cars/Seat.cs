﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars {
    public class Seat : ICar {

        public Seat(string model, string color) {
            Model = model;
            Color = color;

        }
        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start() {
            return "Engine start";
        }

        public string Stop() {
            return "Engine stop";
        }

        public override string ToString() {
            return $"{Color} Seat {Model}";
        }
    }
}
