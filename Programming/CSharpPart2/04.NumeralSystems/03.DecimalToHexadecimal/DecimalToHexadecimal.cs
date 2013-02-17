using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        int decimalNum = int.Parse(Console.ReadLine());
        StringBuilder hexNumber = new StringBuilder();
        while (decimalNum > 0)
        {
                switch (decimalNum % 16)
                {
                    case 10: hexNumber.Append("A"); break;
                    case 11: hexNumber.Append("B"); break;
                    case 12: hexNumber.Append("C"); break;
                    case 13: hexNumber.Append("D"); break;
                    case 14: hexNumber.Append("E"); break;
                    case 15: hexNumber.Append("F"); break;
                    default: hexNumber.Append(decimalNum % 16); break;
                }
                decimalNum /= 16;
        }

        string endNum = hexNumber.ToString();
        for (int i = endNum.Length - 1; i > -1; i--)
        {
            Console.Write(endNum[i]);
        }
        Console.WriteLine();
    }
}
