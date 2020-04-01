using System;
using System.Text.RegularExpressions;

namespace sol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string str = Console.ReadLine();

            Regex RegExp = new Regex(@"\d+");

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
