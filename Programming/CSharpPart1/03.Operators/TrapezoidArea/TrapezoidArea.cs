using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            double sideA = 5;
            double sideB = 4;
            double height = 10;
            double Area = ((sideA + sideB) * height) / 2;
            Console.WriteLine("The area of the trapezoid with side A = {0}  side B = {1} and height = {2} is {3}", sideA, sideB, height,Area);
        }
    }
}
