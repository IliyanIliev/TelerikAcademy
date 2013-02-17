using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WhichDayIsToday
{
    static void Main(string[] args)
    {
        DateTime today = new DateTime();
        Console.WriteLine(today.DayOfWeek);  
    }
}
