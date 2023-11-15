using System;

namespace Tymakov_10
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public bool Visible { get; set; }

        public Figure(string color, bool visible = true)
        {
            Color = color;
            Visible = visible;
        }

        public abstract void MoveHorizontal(int distance);
        public abstract void MoveVertical(int distance);

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public string GetVisibility()
        {
            return Visible ? "видимая" : "невидимая";
        }

        public void Display()
        {
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Видимость: {GetVisibility()}");
        }
    }
}
