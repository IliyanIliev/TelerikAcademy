using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        string hexNumber = Console.ReadLine();
        int decNumber = 0;
        int curDigit = 0;
        for (int i = hexNumber.Length - 1; i >= 0;i--)
        {
            switch (hexNumber[i])
            {
                case 'A': curDigit = 10; ; break;
                case 'B': curDigit = 11; ; break;
                case 'C': curDigit = 12; ; break;
                case 'D': curDigit = 13; ; break;
                case 'E': curDigit = 14; ; break;
                case 'F': curDigit = 15; ; break; ;
                default: curDigit = hexNumber[i] - '0'; ; break;
            }

            decNumber += (curDigit) * (int)(Math.Pow(16,hexNumber.Length - 1 - i));
        }

        Console.WriteLine(decNumber);
    }
}
