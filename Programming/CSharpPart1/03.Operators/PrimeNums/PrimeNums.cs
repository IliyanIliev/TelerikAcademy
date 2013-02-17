using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNums
{
    class PrimeNums
    {
        static void Main(string[] args)
        {
            int someNum;
            bool isPrime = true;
            Console.WriteLine("Enter a number between 1 and 100.");
            someNum = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(someNum); i++)
            {
                if (someNum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime");
        }
    }
}
