using System;

namespace sol1
{
    class Program
    {
        static void unevenSummary(double[] array)
        {
            double unevenSum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                unevenSum += array[i];
            }
            Console.WriteLine("Sum of uneven elements = {0}", unevenSum);
        }

        static void sumBetween(double[] array)
        {
            double sum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > 0)
                    sum += array[i];
                else break;
            }
            Console.WriteLine("Sum between 1st and the last negative element = {0}", sum);
        }

        static void arrayCompression(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 1) array[i] = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == 0)
                    {
                        array[i] = array[j];
                        array[j] = 0;
                    }
                    else break;
                }
            }

            Console.WriteLine("Final array:\t");
            output(array);
        }

        
        static void input(out double[] array)
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            array = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void output(double[] array)
        {
            foreach (int j in array)
            {
                Console.Write("{0, 4}", j);
            }
        }

        static void Main(string[] args)
        {
            double[] array;

            input(out array);
            unevenSummary(array);
            sumBetween(array);
            arrayCompression(array);
        }
    }
}
