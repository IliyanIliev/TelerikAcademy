using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractDates
{
    static void Main(string[] args)
    {
        string format = "dd.MM.yyyy";

        string text = "18.06.2015 Lorem Ipsum 21.02.1994 and some wrong date 01.02.210 ";

        foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
        {

            string extractedToString = Convert.ToString(extracted);

            DateTime date = DateTime.ParseExact(extractedToString, format, CultureInfo.InvariantCulture);

            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}