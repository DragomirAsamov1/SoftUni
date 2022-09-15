using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman {
    public class Car {
        public Car() {

        }

        public Car(string model, Engine engine) {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = @"n/a";
        }

        public Car(string model, Engine engine, int weight) 
            : this(model, engine) {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) 
            : this(model, engine) {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) 
            : this(model, engine, weight) {
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Model + ":");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");
            sb.AppendLine($"    Displacement: {(Engine.Displacement == 0 ? "n/a" : Engine.Displacement.ToString())}");
            sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            sb.AppendLine($"  Weight: {(Weight == 0 ? "n/a" : Weight.ToString())}");
            sb.AppendLine($"  Color: {Color}");

            return sb.ToString().Trim();
        }

    }
}
