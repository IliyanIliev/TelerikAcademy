using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArraysElements
{
    class CompareArraysElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of elements that both arrays should have:");
            int size = int.Parse(Console.ReadLine());
            int[] firstArray = new int[size];
            int[] secondArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("firstArray[{0}] = ",i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write("secondArray[{0}] = ",i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                if (firstArray[i]==secondArray[i])
                {
                    Console.WriteLine("firstArray[{0}] == secondArray[{0}]",i);
                }
                else
                {
                    Console.WriteLine("firstArray[{0}] != secondArray[{0}]",i);
                }
            }
        }
    }
}
