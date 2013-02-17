using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main(string[] args)
    {
        string someText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords = "PHP, CLR, Microsoft";

        forbiddenWords = forbiddenWords.Replace(", ", "|"); //This will help to work with regular expressions
        string pattern = forbiddenWords;

        someText = Regex.Replace(someText, pattern, m => new string('*', m.Length));
        Console.WriteLine(someText);
    }
}