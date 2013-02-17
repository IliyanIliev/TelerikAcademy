using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleParameters
{
    class CircleParameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius: ");
            double radius = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = 2 * Math.PI * radius * radius;
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }
    }
}
