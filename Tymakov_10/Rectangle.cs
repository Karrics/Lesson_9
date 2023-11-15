using System;

namespace Tymakov_10
{
    internal class Rectangle: Point
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height, string color, bool visible = true)
            : base(x, y, color, visible)
        {
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
