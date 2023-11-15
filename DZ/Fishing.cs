using System;
using static DZ.Program;

namespace DZ
{
    internal class Fishing: IGame
    {
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Рыбалка");
        }
    }
}
