using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do {
                Console.Write("x = ");
                float x = float.Parse(Console.ReadLine());

                if (x == -2 || x == (2 * Math.Pow(-1, 1.0 / 3)) || x == (-2 * Math.Pow(-1, 2/3))) // Проверка условий, иначе выдаст бесконечность
                {
                    Console.Write("Error, try again\n");
                }
                else // Если все ок - считаем по условию
                {
                    double y = (3 / Math.Abs(Math.Pow(x, 3) + 8));
                    Console.Write("y = 3/|x^3 + 8| = {0}", y); // Выводим результат
                    break;
                }
            } while(true) ;

            Console.ReadKey();
        }
    }
}
