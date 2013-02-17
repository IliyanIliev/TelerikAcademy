using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkDaysNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please entter the date in this format Day/Month/Year");
        string[] dateStr = Console.ReadLine().Split('/');
        int day = int.Parse(dateStr[0]);
        int month = int.Parse(dateStr[1]);
        int year = int.Parse(dateStr[2]);

        DateTime today = DateTime.Today;
        DateTime finalDay = new DateTime(year, month, day);

        int daysCount = Math.Abs((finalDay - today).Days);
        if (today > finalDay)
        {
            today = finalDay;
            finalDay = DateTime.Today;
        }

        int currentYear = DateTime.Now.Year;
        DateTime[] holidays =
        {
            new DateTime(currentYear, 1, 1),
            new DateTime(currentYear, 3, 3),
            new DateTime(currentYear, 5, 1),
            new DateTime(currentYear, 5, 2),
            new DateTime(currentYear, 5, 6),
            new DateTime(currentYear, 5, 24),
            new DateTime(currentYear, 9, 22),
            new DateTime(currentYear, 12, 24),
            new DateTime(currentYear, 12, 25),
            new DateTime(currentYear, 12, 26),
            new DateTime(currentYear, 12, 31),
        };

        int workDayCounter = 0;
        bool isHoliday = false;

        for (int i = 0; i < daysCount; i++)
        {
            today = today.AddDays(1);
            if (today.DayOfWeek != DayOfWeek.Sunday && today.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (today == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDayCounter++;
                }

                isHoliday = false;
            }

        }

        Console.WriteLine(workDayCounter);
    }
}
