using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UpperCase
{
    static void Main(string[] args)
    {
        string input = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string tagName = "upcase";
        string openTag = "<" + tagName + ">";
        string closeTag = "</" + tagName + ">";
        int openPos = 0;
        int closePos = 0;
        while (input.IndexOf(openTag) != -1)
        {
            openPos = input.IndexOf(openTag);
            closePos = input.IndexOf(closeTag);
            string result = input.Substring(openPos + openTag.Length, closePos - (openPos + openTag.Length));
            input = input.Replace(openTag + result + closeTag, result.ToUpper());
        }
        Console.WriteLine(input);
    }
}

