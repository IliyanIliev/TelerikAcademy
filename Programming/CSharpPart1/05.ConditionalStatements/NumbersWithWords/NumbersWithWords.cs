using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersWithWords
{
    class NumbersWithWords
    {
        static void Main(string[] args)
        {
            int num;
            string[] digits = new string[10] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = new string[10] { "and", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] afterDigits = new string[10] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen" };
            Console.Write("Write a number between 1 - 999 : ");
            num = int.Parse(Console.ReadLine());
            if (num > 0 && num < 10)
            {
                Console.WriteLine(digits[num]);
            }
            else if (num > 10 && num < 20)
            {
                int i = num % 10;
                Console.WriteLine(afterDigits[i]);
            }
            else if ((num >= 20 && num < 100) || num == 10)
            {
                int d1, d10;
                d1 = num % 10;
                d10 = num / 10;

                Console.WriteLine(tens[d10] + " " + digits[d1]);
            }
            else if (num >= 100 && num < 1000)
            {
                int d1, d10, d100;
                d1 = num % 10;
                d10 = (num / 10) % 10;
                d100 = num / 100;
                if (d1 == 0 && d10 == 0)
                {
                    Console.WriteLine(digits[d100] + " hundred");
                }
                else
                {
                    Console.WriteLine(digits[d100] + " hundred " + tens[d10] + " " + digits[d1]);
                }
            }
            else
            {
                Console.WriteLine("The number is out of range..");
            }
        }
    }
}
