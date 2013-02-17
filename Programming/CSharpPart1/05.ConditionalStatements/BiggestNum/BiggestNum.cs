using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNum
{
    class BiggestNum
    {
        static void Main(string[] args)
        {
            int firstNum = 2;
            int secondNum = 4;
            int thirdNum = 3;
            int biggestNum;

            if (firstNum>secondNum)
            {
                if (firstNum>thirdNum)
                {
                    biggestNum = firstNum;
                }
                else
                {
                    biggestNum = thirdNum;
                }
            }
            else
            {
                if (secondNum>thirdNum)
                {
                    biggestNum = secondNum;
                }
                else
                {
                    biggestNum = thirdNum;
                }
            }

            Console.WriteLine("The biggest num is {0}",biggestNum);
        }
    }
}
