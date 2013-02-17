using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumSequence
{
    class MaxSumSequence
    {
        static void Main(string[] args)
        {
            int[] myArray = { -2,-4,10,12,7 };
            int currentSum = myArray[0];
            int maxSum = myArray[0];
            int tempStart = 0;
            int bestStart = 0;
            int bestFinal = 0;

            for (int i = 1; i < myArray.Length; i++)
            {
                currentSum += myArray[i];
                if (myArray[i] > currentSum)
                {
                    currentSum = myArray[i];
                    tempStart = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestStart = tempStart;
                    bestFinal = i;
                }
            }

            for (int i = bestStart; i <= bestFinal; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine();
        }
    }
}
