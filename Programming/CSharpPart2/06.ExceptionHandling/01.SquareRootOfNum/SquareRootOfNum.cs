using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareRootOfNum
{
    static double CalcSqrt(double num)
    {
        if (num < 0)
        {
            throw new ArithmeticException("Please enter only non-negative numbers.");
        }
        return Math.Sqrt(num);
    }
    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            double result = CalcSqrt(number);
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("You've entered an invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The input number is too big or too small!");
        }
        catch (ArithmeticException ae)
        {
            Console.WriteLine("Invalid number: {0}", ae.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye! :)");
        }
    }
}
