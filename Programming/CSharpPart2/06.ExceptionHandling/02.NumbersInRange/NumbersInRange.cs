using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersInRange
{
    static int ReadNumber(int start, int end, int number)
    {
        int n = 1;
        Console.Write("Please enter number {0}: ", number);
        n = int.Parse(Console.ReadLine());
        if (n < start || n > end)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return n;
    }
    static void Main()
    {
        Console.WriteLine("This program reads 10 number in the interval (1..100).");
        Console.WriteLine("Each entered number should be greater than the previous.");
        int n = 1;
        try
        {
            for (int i = 1; i <= 10; i++)
            {
                n = ReadNumber(n, 100, i);
            }
        }
        catch (System.FormatException) // Catches exception if the input is not a number
        {
            Console.WriteLine("Not an integer number.");
        }
        catch (System.OverflowException) // Catches exception if the input out of integer scope
        {
            Console.WriteLine("Not in the scope of integer.");
        }
        catch (System.ArgumentNullException) // Catches exception if the input is null
        {
            Console.WriteLine("Null is not an integer number.");
        }
        catch (System.ArgumentOutOfRangeException) // Catches exception if the input is not in range
        {
            Console.WriteLine("The entered number is not in range.");
        }
    }
}
