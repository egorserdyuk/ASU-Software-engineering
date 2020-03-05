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
            for (int i = 100; i < 1000; i++)
            {
                int[] mas = { i / 100, i % 100 };
                if (mas[0] == mas[1])
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
