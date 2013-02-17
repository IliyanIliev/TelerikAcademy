using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetIsZero
{
    class SubsetIsZero
    {
        private static string getSign(int num, bool noSign = false)
        {
            if (noSign == true)
            {
                return num.ToString();
            }
            else
            {
                if (num > 0)
                {
                    return "+" + num;
                }
                else
                {
                    return num.ToString();
                }
            }

        }
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //Check for every 2 numbers
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        Console.WriteLine("{0}{1}=0", getSign(numbers[i],true), getSign(numbers[j]));
                    }
                }
            }
            //Check for every 3 numbers
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            Console.WriteLine("{0}{1}{2}=0", getSign(numbers[i], true), getSign(numbers[j]), getSign(numbers[k]));
                        }
                    }
                }
            }
            //Check for every 4 numbers
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        for (int l = k + 1; l < 5; l++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0)
                            {
                                Console.WriteLine("{0}{1}{2}{3}=0", getSign(numbers[i], true), getSign(numbers[j]), getSign(numbers[k]), getSign(numbers[l]));
                            }
                        }
                    }
                }
            }
            //Check for if the sum of all numbers give 0
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            }
        }
    }
}
