using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapAnyBits
{
    class SwapAnyBits
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
            int p = 4; //exchange p,p+1,p+2,..,p+k-1
            int q=24; //with q,q+1,q+2,..,q+k-1
            int k=3;
            uint someNum = 20;
            for (int i = p; i < p + k - 1; i++)
            {
                if (getBit(someNum, i) != getBit(someNum, i+(q-p)))
                {
                    someNum = reverseBit(someNum, i);
                    someNum = reverseBit(someNum, i + (q - p));
                }
            }
            
            Console.WriteLine(someNum);

        }
    }
}
