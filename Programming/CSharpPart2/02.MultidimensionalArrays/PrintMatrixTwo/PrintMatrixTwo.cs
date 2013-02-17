using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixTwo
{
    class PrintMatrixTwo
    {
        static void Main(string[] args)
        {
            int size = 10;
            int counter = 1;
            int[,] myArray = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0)
                    {
                        myArray[j, i] = counter;
                        counter++;
                    }
                    else
                    {
                        myArray[j, i] = myArray[size - j - 1, i-1] + size;
                    }

                }
            }

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
