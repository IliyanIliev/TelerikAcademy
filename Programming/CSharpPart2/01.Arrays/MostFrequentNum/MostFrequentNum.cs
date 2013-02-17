using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNum
{
    class MostFrequentNum
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 4, 7, 7, 7, 7, 4, 5, 10, 4, 2 };

            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();
            string mostFrequent = "";
            int times = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numsDictionary.ContainsKey(numbers[i]))
                {
                    numsDictionary[numbers[i]]++;
                }
                else
                {
                    numsDictionary.Add(numbers[i], 1);
                }
            }

            foreach (var item in numsDictionary)
            {
                if (item.Value > times)
                {
                    mostFrequent = "";
                    mostFrequent = item.Key.ToString();
                    times = item.Value;
                }
                else if (item.Value == times)
                {
                    mostFrequent += " and " + item.Key;
                }
            }

            Console.WriteLine("Most frequent number in this array is {0}({1} times).", mostFrequent, times);
        }
    }
}
