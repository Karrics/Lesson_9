using System;

namespace Tymakov_10
{
    internal class Point: Figure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, string color, bool visible = true) : base(color, visible)
        {
            X = x;
            Y = y;
        }

        public override void MoveHorizontal(int distance)
        {
            X += distance;
        }

        public override void MoveVertical(int distance)
        {
            Y += distance;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Координаты: ({X}, {Y})");
        }
    }
}
