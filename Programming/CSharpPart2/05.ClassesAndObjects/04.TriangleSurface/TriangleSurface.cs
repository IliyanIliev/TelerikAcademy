using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurface
{
    static double CalcSurface(double a, double h)
    {
        return (a * h) / 2;
    }

    static double CalcSurface(double a, double b, double c)
    {
        double p = ((a + b + c) / 2);
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static double CalcSurface(double a, double b, int angle)
    {
        double sin = Math.Sin( Math.PI*angle / 180);
        return ((a * b * sin) / 2);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("How do you want to calculate the surface of the triangle?");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("1.By side and an altitude to it.");
        Console.WriteLine("2.By three sides;");
        Console.WriteLine("3.Two sides and an angle between them.");
        byte choose = byte.Parse(Console.ReadLine());
        double firstSide, secondSide;
        switch (choose)
        {
            case 1:
                Console.Write("First side = ");
                firstSide = double.Parse(Console.ReadLine());
                Console.Write("Attitude = ");
                double attitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface of the triangle is equal to {0}.", CalcSurface(firstSide, attitude));
                break;
            case 2:
                Console.Write("First side = ");
                firstSide = double.Parse(Console.ReadLine());
                Console.Write("Second side = ");
                secondSide = double.Parse(Console.ReadLine());
                Console.Write("Third side = ");
                double thirdSide = double.Parse(Console.ReadLine());
                Console.WriteLine("The surface of the triangle is equal to {0}.", CalcSurface(firstSide, secondSide, thirdSide));
                break;
            case 3:
                Console.Write("First side = ");
                firstSide = double.Parse(Console.ReadLine());
                Console.Write("Second side = ");
                secondSide = double.Parse(Console.ReadLine());
                Console.Write("Angle between them = ");
                int angle = int.Parse(Console.ReadLine());
                Console.WriteLine("The surface of the triangle is equal to {0}.", CalcSurface(firstSide, secondSide, angle));
                break;

            default: Console.WriteLine("Invalid choose!"); break;
        }

    }
}
