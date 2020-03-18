using System;

namespace sol1
{
    class Program
    {
        static void beforeColon(string str) //Вывод символов после двоеточия
        {
            bool flag = false; //Если нет двоеточий
            for (int x = 0; x < str.Length; x++) //Находим где стоит первое двоеточие
            {
                if (str[x] == ':') //Выбираем символы до первого двоеточия
                {
                    flag = true;
                    Console.Write("Characters before the first colon: ");
                    for (int i = 0; i < x; i++)
                        Console.Write(str[i]);
                    break;
                }
            }

            if (!flag)
                Console.Write("There are no colons in the line");
        }

        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();

            beforeColon(str);

            //Console.WriteLine(str.Split(':')[0]); //Хех, это тоже работает стабильно
        }

    }
}
