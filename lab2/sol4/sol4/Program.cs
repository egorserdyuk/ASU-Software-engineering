using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2sol4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i < 1000; i += 101)
            {
                Console.WriteLine(i); // Переделал вывод через цикл
            }

            Console.ReadKey();
        }
    }
}
