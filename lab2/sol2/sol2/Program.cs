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
            x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());

            const int R = 10;

            if ((x * x + y * y < R * R) && (y > -x)) Console.WriteLine("Yes");
            else if (x * x + y * y > R * R) Console.WriteLine("Not");
            else Console.WriteLine("On the board");

            Console.ReadKey();
        }
    }
}
