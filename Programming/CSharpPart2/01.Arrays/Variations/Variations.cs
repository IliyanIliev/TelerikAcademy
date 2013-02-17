using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Variations
    {
        static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void GetVariations(int index, int n, int k, int[] arr)
        {
            if (index == k)
            {
                PrintArr(arr);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    GetVariations(index + 1, n, k, arr);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] myArr = new int[k];
            GetVariations(0, n, k, myArr);
        }
    }
}
