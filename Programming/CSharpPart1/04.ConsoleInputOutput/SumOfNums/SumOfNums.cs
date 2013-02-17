using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNums
{
    class SumOfNums
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int someNum = int.Parse(Console.ReadLine());
            int sumNums=0;
            int temp;
            for (int i = 0; i < someNum; i++)
            {
                temp = int.Parse(Console.ReadLine());
                sumNums += temp;
            }
            Console.WriteLine("The sum is {0}",sumNums);
        }
    }
}
