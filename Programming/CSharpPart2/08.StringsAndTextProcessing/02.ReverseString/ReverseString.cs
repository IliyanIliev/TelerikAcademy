using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main(string[] args)
    {
        //Read the input
        string input = Console.ReadLine();
        //Represent string as array of chars
        char[] someInput = input.ToCharArray();
        //Reverse the array
        Array.Reverse(someInput);
        //Print the result
        Console.WriteLine(someInput);
    }
}