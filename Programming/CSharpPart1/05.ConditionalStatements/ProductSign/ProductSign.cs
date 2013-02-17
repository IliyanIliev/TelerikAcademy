using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSign
{
    class ProductSign
    {
        static void Main(string[] args)
        {
            int firstNum=-1;
            int secondNum=2;
            int thirdNum=-3;
            byte count = 0;
            char sign;
            if (firstNum < 0)
            {
                count++;
            }
            if (secondNum < 0)
            {
                count++;
            }
            if (thirdNum < 0)
            {
                count++;
            }

            if (count%2==0)
            {
                sign='+';
            }
            else
            {
                sign = '-';
            }

            Console.WriteLine("The sign of the product is {0}",sign);
        }
    }
}
