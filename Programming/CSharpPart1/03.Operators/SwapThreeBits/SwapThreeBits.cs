using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapThreeBits
{
    class SwapThreeBits
    {
        static uint getBit(uint num, int pos)
        {
            return ((num & (1 << pos)) != 0) ? (uint)1 : 0;
        }

        static uint reverseBit(uint num, int pos)
        {
            return (uint)(num ^ (1 << pos));
        }
        static void Main(string[] args)
        {
            uint someNum = 20;
            if (getBit(someNum, 3) != getBit(someNum, 24))
            {
                someNum=reverseBit(someNum, 3);
                someNum = reverseBit(someNum, 24);
            }
            if (getBit(someNum, 4) != getBit(someNum, 25))
            {
                someNum = reverseBit(someNum, 4);
                someNum = reverseBit(someNum, 25);
            }
            if (getBit(someNum, 5) != getBit(someNum, 26))
            {
                someNum = reverseBit(someNum, 5);
                someNum = reverseBit(someNum, 26);
            }

            Console.WriteLine(someNum);

        }
    }
}
