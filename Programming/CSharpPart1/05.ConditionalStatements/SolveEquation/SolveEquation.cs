using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
    class SolveEquation
    {
        static void Main(string[] args)
        {
            Console.Write("a:");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = int.Parse(Console.ReadLine());
            Console.Write("c:");
            double c = int.Parse(Console.ReadLine());
            double x1;
            double x2;
            double disc = b * b - 4 * a * c;
            if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / 2 * a;
                x2 = (-b - Math.Sqrt(disc)) / 2 * a;
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (disc == 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / 2 * a;
                Console.WriteLine("x1 = {0}", x1);
            }
            else
            {
                Console.WriteLine("The equation doesn't have real roots.");
            }
        }
    }
}