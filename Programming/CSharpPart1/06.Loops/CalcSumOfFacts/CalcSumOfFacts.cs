using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSumOfFacts
{
    class CalcSumOfFacts
    {
        public static int calcFact(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("X = ");
            int X = int.Parse(Console.ReadLine());
            double sum=1;

            for (int i = 1; i <= N; i++)
            {
                sum += calcFact(i) / Math.Pow(X, i);
            }

            Console.WriteLine("The sum is equal to {0}", sum);
        }
    }
}
