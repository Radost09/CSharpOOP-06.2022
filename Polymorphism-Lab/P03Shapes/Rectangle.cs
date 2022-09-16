using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //height and width for Rectangle

        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height 
        { 
            get { return this.height; }
            private set { this.height = value; }
        }
        public double Width 
        { 
            get { return this.width; }
            private set { this.width = value; }
        }
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Height + 2 * Width;
        }
        public override string Draw()
        {
            return base.Draw() + $"{this.GetType().Name}";
        }
    }
}
