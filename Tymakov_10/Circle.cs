using System;

namespace Tymakov_10
{
    internal class Circle: Point 
    {
        public double Radius { get; set; }

        public Circle(int x, int y, double radius, string color, bool visible = true)
            : base(x, y, color, visible)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
