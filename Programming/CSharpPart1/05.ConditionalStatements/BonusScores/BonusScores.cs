using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1:
                case 2:
                case 3: digit *= 10; break;
                case 4:
                case 5:
                case 6: digit *= 100; break;
                case 7:
                case 8:
                case 9: digit *= 1000; break;
                default: Console.WriteLine("Error! :)"); break;
            }
            Console.WriteLine("The new number after the bonus is {0}", digit);
        }
    }
}
