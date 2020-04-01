using System;
using System.Text;

namespace sol2
{
    class Program
    {
        static void delNums(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)    //Гуляем по строке
            {
                if (char.IsDigit(str[i])) //И если значение - цифра
                {
                    str.Remove(i, 1); //Удаляем
                    i -= 2;
                }
            }

            Console.WriteLine("New line: {0}", str); //Выводим новую строку
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            StringBuilder myStr = new StringBuilder(str);

            delNums(myStr);
            Console.WriteLine(myStr);
        }
    }
}
