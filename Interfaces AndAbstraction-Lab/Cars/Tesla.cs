using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{this.Color} {this.Model} with {this.Battery} Batteries");
            return output.ToString().Trim();
        }
    }
}
