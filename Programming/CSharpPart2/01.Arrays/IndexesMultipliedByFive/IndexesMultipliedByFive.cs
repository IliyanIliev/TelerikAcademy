using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexesMultipliedByFive
{
    class IndexesMultipliedByFive
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = 5 * i;
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
