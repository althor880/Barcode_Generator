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
            System.String testString1 = "[Meadows]";
            System.String testString2 = "[Meadows]Data Source=10.209.41.166:1521/MEADOW;User ID=viewer;Password=cprt_hsi;Unicode=True";
            System.Text.RegularExpressions.Regex testRegEx = new Regex("\\[(\\w+)\\](.+)");
            System.Text.RegularExpressions.Match testMatch = testRegEx.Match(testString2);
            Console.WriteLine(testMatch.Groups[1]);
            Console.WriteLine(testMatch.Groups[2]);
            Console.ReadLine();
        }
    }
}
