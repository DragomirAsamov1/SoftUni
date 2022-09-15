﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars {
    public class Tesla : ICar, IElectricCar {
        public Tesla(string model, string color, int battery) {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public int Battery {get; private set;}

        public string Model { get; private set;}

        public string Color { get; private set;}

        public string Start() {
            return "Engine start";
        }

        public string Stop() {
            return "Engine stop";
        }

        override public string ToString() {
            return $"{Color} Tesla {Model} with {Battery} Batteries";
        }
    }
}
