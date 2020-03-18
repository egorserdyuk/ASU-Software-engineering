using System;

namespace sol1
{
    class Program
    {
        static void unevenSummary(double[] array)   //Метод суммирования нечетных ячеек
        {
            double unevenSum = 0;   //Инциализация переменной суммы

            for (int i = 1; i < array.Length; i += 2)   //Проходим массив с соответстующим шагом
            {
                unevenSum += array[i];  //Суммируем
            }
            Console.WriteLine("Sum of uneven elements = {0}", unevenSum);
        }

        static void sumBetween(double[] array)  //Метод суммирования между 1 и последним отрицательным числом
        {
            double sum = 0;
            
            for (int i = array.Length - 1; i > 0; i--)  //Начинаем с конца искать последний отрицательный элемент
            {
                if (array[i] < 0)   //Находим
                {
                    for (int j = 1; j < i; j++) //
                    {
                        sum += array[j];
                        if (array[j] == array[i]) break;
                    }
                    break;
                }
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
