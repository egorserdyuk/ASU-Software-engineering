using System;
using System.Text.RegularExpressions;

namespace sol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string str = Console.ReadLine();
            //string str = "100 USD, 22 UDD, 0.002 USD, 200 RUR, 32.21 USD, 666 JPN, 10 EU, 10 CHF, 0.5 RUR"; // На чем проверял

            Regex RegExp = new Regex(@"((\s\d+)|(\A(\d+))|(\d+\.\d{1,2}))\s(?:USD|EU|RUR)"); // Тут мы ищем числа, которые: с точкой, но не более 2 символов; целые; все они должны быть подписаны валютой EU, RUR или USD
            MatchCollection matchcollection = RegExp.Matches(str);

            string text = "";
            string textEnd = "";

            MatchCollection matches1 = RegExp.Matches(str);
            if (matches1.Count > 0) {
                for (int i = 0; i < matches1.Count; i++)
                {
                    text += matchcollection[i].Value + " ";
                }

                textEnd = System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " "); // Чистим текст перестановкой по регулярке (против лишних пробелов)

                Console.WriteLine("Numbers are: {0}", textEnd);
            }
            else {
                Console.WriteLine("Error, haven't such expressions");
            }
        }
    }
}
    
