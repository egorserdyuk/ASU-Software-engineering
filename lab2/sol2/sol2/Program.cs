using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace lab2sol2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine()); // Стандартно вводим x и y
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());

            const int R = 10; // Радиус

            if ((x * x + y * y < R * R) && (y > -x)) Console.WriteLine("Yes"); // Проверка на нахождение внутри
            else if (x * x + y * y > R * R) Console.WriteLine("Not"); // Снаружи
            else Console.WriteLine("On the board"); // Иначе - на границе

            Console.ReadKey();
        }
    }
}
