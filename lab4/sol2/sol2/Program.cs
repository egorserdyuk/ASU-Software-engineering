using System;
using System.Text;

namespace sol2
{
    class Program
    {
        static void delNums(StringBuilder str)
        {
            for (int i = 0; i < str.Length; i++)    //Проходим по строке и если
            {
                if (char.IsDigit(str[i]))
                {
                    str.Remove(i, 1);
                    i -= 2;
                }
            }

            Console.WriteLine("New line: {0}", str);
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
