using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMaxOfN
{
    class MinAndMaxOfN
    {
        static void Main(string[] args)
        {
            int min=0;
            int max=0;
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                
                Console.Write("Number {0} = ", i);
                int num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    min = num;
                    max = num;
                }

                if (num<min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("The biggest num is {0} , and the smallest num is {1}",max,min);
        }
    }
}
