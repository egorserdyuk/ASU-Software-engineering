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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; ++i)
            {
                for (int j = i; j >= 1; --j)
                {
                    if (j == 1) Console.Write("{0, 4}", 3);
                    else Console.Write("{0, 4}", 2);
                }
                Console.WriteLine();

                for (int j = i; j >= 1; --j)
                {
                    if (j == 1) Console.Write("{0, 4}", 0);
                    else Console.Write("{0, 4}", (10 - j));
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
