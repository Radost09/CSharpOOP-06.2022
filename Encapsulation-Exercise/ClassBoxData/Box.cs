using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private const int BoxPropertyMinValue = 0;
        private const string ZeroOrNegativeArgumentExeption = "{0} cannot be zero or negative.";


        private double length;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value < BoxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentExeption, nameof(this.Length)));
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < BoxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentExeption, nameof(this.Width)));
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < BoxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentExeption, nameof(this.Height)));
                }
                this.height = value;
            }
        }

        private double SurfaceArea()
            => (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        private double LateralSurfaceArea()
            => (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        private double Volume()
            => this.Length * this.Width * this.Height;

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output
                .AppendLine($"Surface Area - {this.SurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.Volume():f2}");


            return output.ToString().TrimEnd();
        }
    }
}
