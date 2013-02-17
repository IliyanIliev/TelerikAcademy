using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevidedBySomeNums
{
    class DevidedBySomeNums
    {
        static void Main(string[] args)
        {
            int someNum = 35;
            bool devide = (someNum%5==0 && someNum%7==0);
            Console.WriteLine(devide);
        }
    }
}
