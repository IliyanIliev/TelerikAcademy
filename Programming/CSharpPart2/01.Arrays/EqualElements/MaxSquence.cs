using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSquence
{
    class MaxSquence
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,5,5,6,6,6,7,7,7,4};
            int count = 1;
            int maxCount = 1;
            int value = 0;
            string output = "";
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                while (i< numbers.Length - 1 && numbers[i] == numbers[i + 1])
                {
                    count++;
                        i++;                   
                }

                if (count > maxCount)
                {
                    output = "";
                    maxCount = count;
                    value = numbers[i];
                    for (int j = 0; j < maxCount; j++)
                    {
                         output += value.ToString() + " ";
                    }
                   
                }
                else if (count==maxCount && count!=1)
                {
                    value = numbers[i];
                    output += '\n';
                    for (int j = 0; j < maxCount; j++)
                    {
                        output += value.ToString() + " ";
                    }
                    
                }
                count = 1;
            }
            Console.WriteLine(output);
        }
    }
}
