using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace sol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string str = Console.ReadLine();
            //string str = "6000 7000 3.99 200 or 1337,42 EXAMPLE; 1 EXAMPLE| 520.5969 42 43 320";

            Regex RegExp = new Regex(@"\d+(?!\d+[.,]?\d*)"); // Каждое значение с цифрами не может содержать значения с "," или "."; остальные - ок

            int result = RegExp.Matches(str).Cast<Match>().Max(x => int.Parse(x.ToString())); // Преобразуем Match'и в список и находим максимум
            Console.WriteLine(result);
        }
    }
}
