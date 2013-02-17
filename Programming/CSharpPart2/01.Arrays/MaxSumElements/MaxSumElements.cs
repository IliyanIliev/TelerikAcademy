using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumElements
{
    class MaxSumElements
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];

            //Fill the array
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Elemen {0} = ", i + 1);
                myArray[i]=int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int startIndexSum = 0;
            int currentSum = 0;
            int j;
            for (int i = 0; i <= N-K; i++)
            {
                for (j = i; j < i + K; j++)
                {
                    currentSum += myArray[j];
                }
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    startIndexSum = j-K;
                }
                currentSum = 0;

            }

            for (int i = startIndexSum; i < startIndexSum+K; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }

        }
    }
}
