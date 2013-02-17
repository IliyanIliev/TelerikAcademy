using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10,2, 3, 4, 5,2,5,10,20 };
            int count = 1;
            int maxCount = 1;
            int index = 0;
            string output = "";
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                while (i < numbers.Length - 1 && numbers[i] < numbers[i + 1])
                {
                    count++;
                    i++;
                }

                if (count > maxCount)
                {
                    output = "";
                    maxCount = count;
                    index = i-maxCount + 1;
                    for (int j = index; j < maxCount + index; j++)
                    {
                        output += numbers[j].ToString() + " ";
                    }


                }
                else if (count == maxCount)
                {
                    index = i - maxCount + 1;
                    output += '\n';
                    for (int j = index; j < maxCount + index; j++)
                    {
                        output += numbers[j].ToString() + " ";
                    }
                }

                count = 1;

            }
            Console.WriteLine(output);

        }
    }
}
