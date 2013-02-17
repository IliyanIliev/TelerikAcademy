using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSomeSum
{
    class CalcSomeSum
    {
        static void Main(string[] args)
        {
            double sum = 1;
            for (int i = 2; i < 1000; i++)
            {
                sum += (Math.Pow(-1, i)) / i;
            }
            Console.WriteLine(Math.Round(sum,3));
        }
    }
}
