using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Combinations
    {
        static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void GetCombinations(int index, int start, int n, int k, int[] arr)
        {
            if (index == k)
            {
                PrintArr(arr);
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    arr[index] = i;
                    GetCombinations(index + 1, i+1, n, k, arr);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] myArr = new int[k];
            GetCombinations(0, 1, n, k, myArr);
        }
    }
}
