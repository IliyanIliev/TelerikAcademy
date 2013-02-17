using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitValue
{
    class ExtractBitValue
    {
        static void Main(string[] args)
        {
            int someNum, pos;
            someNum = 35;
            pos = 5;
            Console.WriteLine(((someNum & (1 << pos)) != 0) ? "1" : "0");
        }
    }
}
