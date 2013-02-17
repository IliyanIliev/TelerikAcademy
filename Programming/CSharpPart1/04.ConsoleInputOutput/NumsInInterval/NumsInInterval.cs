using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsInInterval
{
    class NumsInInterval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number one:");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            int numTwo = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = numOne; i <= numTwo; i++)
            {
                if (i % 5 == 0) count++;
            }

            Console.WriteLine("p({0},{1})={2}",numOne,numTwo,count);
        }
    }
}
