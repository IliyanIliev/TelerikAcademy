using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string str = "some@mail.bg sometext here and another mail yeah@gmail.com";

        foreach (var item in Regex.Matches(str, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
        {
            Console.WriteLine(item);
        }
    }
}