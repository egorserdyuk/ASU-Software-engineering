using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, y;
            int i = 1;

            Console.WriteLine("Print [a, b]: ");
            a = Convert.ToDouble(Console.ReadLine()); //левая граница
            b = Convert.ToDouble(Console.ReadLine()); //правая граница

            Console.WriteLine("Print step h: ");
            h = Convert.ToDouble(Console.ReadLine()); //шаг

            Console.WriteLine("{0,3} {1,5} {2,5}", "#", "x", "f(x)");
            for (double x = a; x <= b; x += h, ++i) //цикл от а до b шагом h по условию задачи
            {
                if (x < 1)
                    y = Math.Pow((Math.Pow(x, 2) - 1), 2);
                else if (x > 1)
                    y = 1 / (Math.Pow((1 + x), 2));
                else
                    y = 0;
                Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y); //вывод таблицы
            }
			
			Console.ReadKey();
        }
    }
}