using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    
    class BinarySearch
    {
        public static int RecursiveBinarySearch(int[] myArr, int search, int min, int max)
        {
            
            if (max<min)
            {
                return -1;
            }
            else
            {
                int midPoint = (min + max) / 2;
                if (myArr[midPoint]>search)
                {
                    return RecursiveBinarySearch(myArr, search, min, midPoint - 1);
                }
                else if (myArr[midPoint]<search)
                {
                    return RecursiveBinarySearch(myArr, search, midPoint+1, max);
                }
                else
                {
                    return midPoint;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,15,20,30,40};
            int elementToFind = 3;
            Array.Sort(numbers);
            if (RecursiveBinarySearch(numbers, elementToFind, 0, numbers.Length - 1) == -1)
            {
                Console.WriteLine("There is no such element!");
            }
            else
            {
                Console.WriteLine("The element that you are trying to find is element number {0}", RecursiveBinarySearch(numbers, elementToFind, 0, numbers.Length - 1));
            }
        }
    }
}
