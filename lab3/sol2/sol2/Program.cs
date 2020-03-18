using System;

namespace sol2
{
    class Program
    {
        static void change(double[,] array)
        {
            double min, max, temp;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i, i] > array[max, max])
                {
                    max = i;
                }
                if (array[i, i] < array[min, min])
                {
                    min = i;
                }
            }
            // В цикле меняем местами столбцы
            for (int j = 0; j < array.Length; j++)
            {
                temp = array[j, max];
                array[j, max] = array[j, min];
                array[j, min] = temp;
            }
        }

        static void input(out double[,] array)
        {
            Console.Write("Enter the dimension of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            array = new double[n, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    array[i, j] = double.Parse(Console.ReadLine());
                }
            }

        }

        static void randInput(out double[,] array) //рандомный ввод
        {
            Random rand = new Random();

            Console.Write("Enter the dimension of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            array = new double[n, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-50, 50); //рандомные значения от - 50 до 50
                }
            }
        }

        static void output(double[,] array) //вывод двумерного массива
        {
            Console.WriteLine("Two-dimensional array: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0, 4} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            double[,] array;

            Console.WriteLine("Do you want to input your own data? y/n");
            char check = Convert.ToChar(Console.ReadLine());

            if (check == 'y')
                input(out array);
            else
                randInput(out array);

            change(array);
            output(array);
        }
    }
}
