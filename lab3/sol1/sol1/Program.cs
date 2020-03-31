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

        static void sumBetween(double[] array)  //Метод суммирования между первым и последним отрицательными числам
        {
            double sum = 0;

            int first, last; // Ищем первый и последний отрицательные значения
            for (first = 0; first < array.Length; first++)
            {
                if (array[first] < 0) break; // Находим первый отрицательный элемент
            }
            for (last = array.Length - 1; last > first; last--)
            {
                if (array[last] < 0) break; // Находим последний отрицательный элемент
            }
            for (int i = first + 1; i < last; i++)
            {
                sum += array[i]; // Суммируем значения между ними
            }

            Console.WriteLine("Sum between the 1st and the last negative element = {0}", sum);
        }

        static void arrayCompression(double[] array)    //Метод сжатия массива и установки нулей на место удаленных элементов в конце массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 1) array[i] = 0;   //Находим по модулю подходящие значения и удаляем их, присваивая 0
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)  //Сортируем, передвигая 0 в конец
                {
                    if (array[i] == 0)
                    {
                        array[i] = array[j];
                        array[j] = 0;
                    }
                    else break; //Ну, или если у нас нету нулей, то ничего не происходит
                }
            }

            Console.WriteLine("Final array:\t");
            output(array);
        }

        
        static void input(out double[] array)   //Метод ввода массива
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

        static void output(double[] array)  //Метод вывода массива
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
