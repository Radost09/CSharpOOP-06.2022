
namespace Cars
{
    using System;
    using System.Text;

    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get ; set ; }
        public string Color { get ; set ; }

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
            output.AppendLine($"{this.Color} {this.Model}");
            return output.ToString().Trim();
        }
    }
}
