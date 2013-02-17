using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThirdDigitSeven
{
    class IsThirdDigitSeven
    {
        static void Main(string[] args)
        {
            int someNum = 1732;
            bool isSeven = ((someNum/100)%10==7);
            Console.WriteLine(isSeven);
        }
    }
}
