using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTheBitOne
{
    class IsTheBitOne
    {
        static void Main(string[] args)
        {
            int someNum, pos;
            someNum = 5;
            pos = 1;
            Console.WriteLine(((someNum & (1 << pos)) != 0) ? true : false);
        }
    }
}
