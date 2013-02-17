using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharElements
{
    class CompareCharElements
    {
        static void Main(string[] args)
        {
            char[] firstArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            char[] secondArray = { 'a', 'v', 'R', 'd', 'e', 'f', 'g' };

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.Write("The element {0} is after element {1} lexicographically!", firstArray[i], secondArray[i]);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.Write("The element {0} is before element {1} lexicographically!", firstArray[i], secondArray[i]);
                }
                else
                {
                    Console.Write("The elements {0} is equal to {1}!", firstArray[i], secondArray[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
