using System;
using System.Text;

namespace sol3
{
    class Program
    {

        static void alphabetSort(string str)
        {
            char[] splitter = { ' ', ',', '.', ';', ':', '!', '?', '-' }; //Указываем разделители слов

            string[] words = str.Split(splitter, StringSplitOptions.RemoveEmptyEntries); //Создаем список значений, состоящий из слов

            Array.Sort(words); //Сортируем

            Console.WriteLine(string.Join(" | ", words)); //Выводим через разделитель отсротированное по алфавиту сообщение
        }
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();

            StringBuilder myStr = new StringBuilder(str);

            alphabetSort(str);
        }
    }
}
