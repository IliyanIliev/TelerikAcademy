using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostAppropriateType
{
    class MostAppropriateType
    {
        static void Main(string[] args)
        {
            ushort varOne = 52130;
            sbyte varTwo = -115;
            int varThree = 4825932;
            sbyte varFour = 93;
            short varFive = -10000;
            Console.WriteLine("The five given numbers have these values:{0} {1} {2} {3} {4}", varOne, varTwo, varThree, varFour, varFive);
        }
    }
}
