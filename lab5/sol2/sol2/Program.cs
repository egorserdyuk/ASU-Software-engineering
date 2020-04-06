using System;
using System.Text.RegularExpressions;

namespace sol2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input string: ");
            //string str = Console.ReadLine();
            string str = "22 UDD, 0.002 USD, 200 RUR, 32.21 USD, 666 JPN, 10 EU, 10 CHF";

            Regex RegExp = new Regex(@"(?:^|[\n\r]|[^\w\d\.])([1-9]\d*(?:.\d{,2})?\s*(?:USD|EU|RUR))\b");

            MatchCollection matches = RegExp.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine("Result = {0}", match.Value);
            }
            else
            {
                Console.WriteLine("Error, haven't such expressions");
            }
        }
    }
}
