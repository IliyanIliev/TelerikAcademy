using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNum
{
    class GreaterNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number one:");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            int numTwo = int.Parse(Console.ReadLine());
            Console.Write("The greater number is ");
            Console.WriteLine(numOne>numTwo? numOne:numTwo);
        }
    }
}
