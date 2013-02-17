using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsNotDivisible3And7
{
    class NumsNotDivisible3And7
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i%21!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}