using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_10
{
    public interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("упр 10.1");
            Console.WriteLine("Шифровка и дешифровка строк");
            string text_1 = "Hello, World!";
            ICipher acipher = new ACipher();
            string encodedTextA = acipher.Encode(text_1);
            string decodedTextA = acipher.Decode(encodedTextA);
            Console.WriteLine("Encoded (ACipher): " + encodedTextA);
            Console.WriteLine("Decoded (ACipher): " + decodedTextA);

            string text_2 = "Hello, World!";
            ICipher bcipher = new BCipher();
            string encodedTextB = bcipher.Encode(text_2);
            string decodedTextB = bcipher.Decode(encodedTextB);
            Console.WriteLine("Encoded (BCipher): " + encodedTextB);
            Console.WriteLine("Decoded (BCipher): " + decodedTextB);
            Console.WriteLine();

            Console.WriteLine("Дз 10.1");
            Console.WriteLine("Класс для работы с геометрическими фигурами");
            Point point = new Point(5, 10, "Red", true); // Создание объекта Point с координатами (5, 10)
            point.Display(); // Вызов метода Display для отображения координат точки
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
