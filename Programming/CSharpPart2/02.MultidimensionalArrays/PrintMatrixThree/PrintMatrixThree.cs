using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixThree
{
    class PrintMatrixThree
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[,] myArray = new int[size, size];
            int counter = 1;

            //Fill the first half
            for (int i = size-1; i >=0; i--)
            {
                for (int j = i; j <= size-1; j++)
                {
                    myArray[j, j-i] = counter;
                    counter++;
                }
            }

            //Fill the second half
            for (int i = - 1; i >= 1-size; i--)
            {
                for (int j = 0; j <= size + i- 1; j++)
                {
                    myArray[j, j - i] = counter;
                    counter++;
                }
            }

            //Print the matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,4}", myArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
