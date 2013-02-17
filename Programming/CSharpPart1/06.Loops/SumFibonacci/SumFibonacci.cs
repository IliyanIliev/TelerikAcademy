using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] members;
            decimal sum=0;
            members = new decimal[105];
            members[0] = 0;
            members[1] = 1;
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                members[i] = members[i - 1] + members[i - 2];
            }

            for (int i = 0; i < n; i++)
            {
                sum+=members[i];
            }
            Console.WriteLine("The sum of the first {0} numbers of the Fibonacci sequence is equal to {1} .", n, sum);
        }
    }
}
