using System;
using System.Text;

namespace sol2
{
    class Program
    {
        static void delNums(StringBuilder s)
        {
            bool isLastDigit = false;
            bool isRemoved = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]) && isLastDigit) // если два символа рядом, то считаем это подстрокой и удаляем ее
                {
                    if (!isRemoved) // если не удалили предыдущую цепочку, то удаляем ее
                    {
                        s.Remove(i - 1, 2);
                        isRemoved = true; // цепочка удалена
                        i -= 2;
                    }
                    else          // если удаляли цепочку,
                    {
                        s.Remove(i, 1); //  то нужно удалить только один символ
                        i--;
                    }
                }
                else if (Char.IsDigit(s[i]) && !isLastDigit) // если текущий символ цифра, а последний не был цифрой
                {
                    isLastDigit = true; // то эта цифра является началом подстроки
                    isRemoved = false;
                }
                else
                {
                    isLastDigit = false; // иначе сбрасываем флаг цифровой подстроки
                }
            }

            Console.WriteLine("New line: {0}", s);
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
