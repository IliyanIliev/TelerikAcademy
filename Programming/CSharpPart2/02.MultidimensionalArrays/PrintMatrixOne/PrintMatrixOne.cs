using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixOne
{
    class PrintMatrixOne
    {
        static void Main(string[] args)
        {
            int size = 10;
            int counter = 1;
            int[,] myArray = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    myArray[j, i] = counter;
                    counter++;
                }
            }

            //Print the matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,4}",myArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
