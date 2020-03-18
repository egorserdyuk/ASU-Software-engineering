using System;

namespace sol2
{
    class Program
    {
        static void change(int[,] array)
        {
            int min = 0, max = 0, temp;

            for (int i = 0; i < array.GetLength(0); i++)
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
            
            for (int j = 0; j < array.GetLength(0); j++)  //В цикле меняем местами столбцы
            {
                temp = array[j, max];
                array[j, max] = array[j, min];
                array[j, min] = temp;
            }

            Console.Write("Changed ");
            output(array);
        }

        static void input(out int[,] array)
        {
            Console.Write("Enter the dimension of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            array = new int[n, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Source ");
            output(array);
        }

        static void randInput(out int[,] array) //рандомный ввод
        {
            Random rand = new Random();

            Console.Write("Enter the dimension of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            array = new int[n, n];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-50, 50); //рандомные значения от - 50 до 50
                }
            }

            Console.Write("Source random ");
            output(array);
        }

        static void output(int[,] array) //Вывод двумерного массива
        {
            Console.WriteLine("two-dimensional array: ");
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
            int[,] array;

            Console.WriteLine("Do you want to input your own data? y/n");
            char check = Convert.ToChar(Console.ReadLine());

            if (check == 'y')
                input(out array);
            else
                randInput(out array);

            change(array);
        }
    }
}
