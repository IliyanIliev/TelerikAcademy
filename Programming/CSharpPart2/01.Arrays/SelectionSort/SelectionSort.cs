using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] myArray = { 15, 2, 16, 8, 13, 4, 3, 4 };
            int temp;
            int min;
            //Print the array before Selection Sort
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ",myArray[i]);
            }
            Console.WriteLine();

            //Selection Sort
            int k;
            int j;
            for (k = 0; k < myArray.Length-1; k++)
            {
                min=k;
                for (j = k+1; j < myArray.Length; j++)
                {
                    if (myArray[j]<myArray[min])
                    {
                        min = j;
                    }
                }

                if (min!=k)
                {
                    temp = myArray[k];
                    myArray[k] = myArray[min];
                    myArray[min] = temp;
                }
            }

            //Print the array after Selection Sort
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine();
        }
    }
}
