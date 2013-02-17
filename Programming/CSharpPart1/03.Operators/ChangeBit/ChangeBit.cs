using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeBit
{
    class ChangeBit
    {
        static void Main(string[] args)
        {
            int num, pos, val, bitVal;
            num = 5;
            pos = 2;
            val = 0;
            if ((num & (1 << pos)) != 0)
            {
                bitVal = 1;
            }
            else
            {
                bitVal = 0;
            }
            if (bitVal == val)
            {
                Console.WriteLine("This bit doesn't have to be changed :)");
            }
            else
            {
                num = num ^ (1 << pos);
                Console.WriteLine("The bit has been changed successfully! The new number is {0} .", num);
            }

        }
    }
}