using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHowOld
{
    class PrintHowOld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your current age: ");
            int myAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: " + (myAge + 10));
        }
    }
}
