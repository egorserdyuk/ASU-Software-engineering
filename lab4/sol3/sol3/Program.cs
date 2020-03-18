using System;
using System.Text;

namespace sol3
{
    class Program
    {

        static void alphabetSort(string str)
        {
            char[] splitter = { ' ', ',', '.', ';', ':', '?' };

            //String[] words = str.Split(splitter);

            Array.Sort(str, StringComparer.InvariantCulture);

            foreach (string item in str)
            {
                Console.WriteLine(item);
            }
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
