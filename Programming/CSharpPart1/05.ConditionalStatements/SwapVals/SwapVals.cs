using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVals
{
    class SwapVals
    {
        static void Main(string[] args)
        {
            int firstNum = 5;
            int secondNum = 2;
            if (firstNum > secondNum)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }

            Console.WriteLine("First:{0}",firstNum);
            Console.WriteLine("Second:{0}", secondNum);

        }
    }
}
