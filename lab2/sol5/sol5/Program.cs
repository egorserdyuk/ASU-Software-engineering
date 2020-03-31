using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2sol5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()); // Сколько раз нужно вывести

            for (int i = 0; i <= n; ++i)
            {
                for (int j = i; j > 0; --j) // Выводим верхний ряд 3 и 2
                {
                    if (j == 1) Console.Write("{0, 4}", 3);
                    else Console.Write("{0, 4}", 2);
                }
                Console.WriteLine();

                for (int j = i; j > 0; --j) // Выводим по закономерности
                {
                    if (j == 1) Console.Write("{0, 4}", 0);
                    else Console.Write("{0, 4}", (11 - j));
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
