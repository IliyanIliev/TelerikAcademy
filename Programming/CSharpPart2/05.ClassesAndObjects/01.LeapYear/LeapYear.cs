using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYear
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year {0} is leap!",year);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap!",year);
        }
    }
}
