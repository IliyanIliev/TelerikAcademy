using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            decimal[] members;
            members = new decimal[105];
            members[0] = 0;
            members[1] = 1;

            for (int i = 2; i < 100; i++)
            {
                members[i] = members[i - 1] + members[i - 2];
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(members[i]);
            }

        }
    }
}
