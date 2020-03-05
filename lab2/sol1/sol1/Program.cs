using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            double y = (3 / Math.Abs(Math.Pow(x, 3) + 8));
            Console.Write("y = 3/|x^3 + 8| = {0}", y);

            Console.ReadKey();
        }
    }
}
