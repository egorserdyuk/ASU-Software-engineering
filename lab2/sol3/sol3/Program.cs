using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2sol3
{
    class Program
    {
        static void Main(string[] args)
        {
            char gender;
            do
            {
                Console.Write("Enter gender to see example names: ");
                gender = char.Parse(Console.ReadLine()); // Получаем запрос на имена
                switch (gender) // Используем switch для удобства 
                {
                    case 'm':
                        Console.Write("Peter, John, George\n");
                        break;
                    case 'f':
                        Console.Write("Eva, Victoria, Julia\n");
                        break;
                    case 'e':
                        break;
                    default:
                        Console.Write("There is only 2 genders\n");
                        break;
                }
            } while (gender != 'e'); // Выходим из цикла при 'e'

            Console.ReadKey();
        }
    }
}
