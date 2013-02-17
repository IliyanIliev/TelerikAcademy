using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescOrder
{
    class DescOrder
    {
        static void Main(string[] args)
        {
            double firstNum = 2;
            double secondNum = 2;
            double thirdNum = 5;

            if (firstNum>=secondNum && firstNum>=thirdNum)
            {
                if (secondNum>=thirdNum)
                {
                    Console.WriteLine("{0}, {1}, {2}",firstNum,secondNum,thirdNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNum, thirdNum, secondNum);
                }
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine("{0}, {1}, {2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", secondNum, thirdNum, firstNum);
                }
            }
            else if (thirdNum >= firstNum && thirdNum >= secondNum)
            {
                if (firstNum >= secondNum)
                {
                    Console.WriteLine("{0}, {1}, {2}", thirdNum, firstNum, secondNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", thirdNum, secondNum, firstNum);
                }
            }
        }
    }
}
