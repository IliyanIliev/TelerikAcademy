using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenNum
{
    class OddOrEvenNum
    {
        static void Main(string[] args)
        {
            int someNum = 10;
            if (someNum%2==0)
            {
                Console.WriteLine(someNum +" is an even number!");
            }
            else
            {
                Console.WriteLine(someNum + " is an odd number!");
            }
        }
    }
}
