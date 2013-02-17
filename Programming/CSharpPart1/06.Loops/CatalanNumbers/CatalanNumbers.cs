using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        public static BigInteger calcFact(int num)
        {
            BigInteger fact=1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger temp=1;
            for (int i = n+2; i <= 2*n; i++)
            {
                temp*=i;
            }

            Console.WriteLine("C({0}) = {1}",n, (temp/(calcFact(n))));
        }
    }
}
