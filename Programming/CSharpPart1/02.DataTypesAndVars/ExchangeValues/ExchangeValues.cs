using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            int firstNumber = 5, secondNumber = 10, someVar;
            Console.WriteLine("We have two given numbers {0} and {1}.", firstNumber, secondNumber);
            Console.WriteLine("We will change the value of the numbers.");
            someVar = secondNumber;
            secondNumber = firstNumber;
            firstNumber = someVar;
            Console.WriteLine("Now the given numbers have changed values.{0} and {1}, ", firstNumber, secondNumber);
        }
    }
}
