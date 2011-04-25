using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String testString2 = "!@Testing123_Blah123%$";
            System.Text.RegularExpressions.Regex testRegEx = new Regex("(\\w+)_(\\w+)");
            System.Text.RegularExpressions.Match testMatch = testRegEx.Match(testString2);
            Console.WriteLine(testMatch.Groups[1]);
            Console.WriteLine(testMatch.ToString());
            Console.WriteLine(testMatch.Length.ToString());
            Console.ReadLine();
        }
    }
}
