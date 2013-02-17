using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxLength
{
    static void Main(string[] args)
    {
        string input = "123456";
        if (input.Length>20)
        {
            input = input.Remove(20, input.Length - 20);
        }
        else if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }

        Console.WriteLine(input);
    }
}