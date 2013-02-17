using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumPlatform3
{
    class MaxSumPlatform3
    {
        static int getMaxSum(int[,] arr, int platformSize, int row, int col)
        {
            int sum = 0;
            for (int i = row; i < row + platformSize; i++)
            {
                for (int j = col; j < col + platformSize; j++)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int currentSum;
            int maxSum = int.MinValue;
            int maxI = 0, maxJ = 0;
            int platformSize = 3;

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] myArray = new int[n, m];

            if (n >= platformSize && m >= platformSize)
            {
                //Fill the matrix
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("Array[{0},{1}] = ", i, j);
                        myArray[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i <= n - platformSize; i++)
                {
                    for (int j = 0; j <= m - platformSize; j++)
                    {
                        currentSum = getMaxSum(myArray, platformSize, i, j);
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            maxI = i;
                            maxJ = j;
                        }
                    }
                }

                //Print the max platform
                for (int i = maxI; i < maxI + platformSize; i++)
                {
                    for (int j = maxJ; j < maxJ + platformSize; j++)
                    {
                        Console.Write("{0,3} ", myArray[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Max sum = {0}", maxSum);

            }
            else
            {
                Console.WriteLine("Matrix is too small.");
            }


        }
    }
}
