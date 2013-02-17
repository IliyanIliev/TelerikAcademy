using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThirdBit
{
    class FindThirdBit
    {
        static void Main(string[] args)
        {
            int someNum=8;
            int mask = 1 << 3;
            Console.WriteLine(((someNum & mask) != 0) ? "1" : "0");
        }
    }
}
