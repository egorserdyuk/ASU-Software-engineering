using System;
using System.Text.RegularExpressions;

namespace sol1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input string: ");
            //string str = Console.ReadLine();
            string example = "31,99 EXAMPLE 0 EXAMPLE 42";

            Regex RegExp = new Regex(@"\d+");

            MatchCollection matches = RegExp.Matches(example);
            if (matches.Count > 0)
            {
                Console.WriteLine("Result = {0}", match.Value);
            }
            else
            {
                Console.WriteLine("Error, haven't such expressions");
            }
        }
    }
}
