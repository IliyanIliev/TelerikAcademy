using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertFromStoD
{
    static void Main(string[] args)
    {
        //Change here the numeral systems
        int s = 2;
        int d = 16;
        //------------------------------
        string someNum = Console.ReadLine();
        int decimalNum = 0;
        for (int i = someNum.Length - 1; i >= 0; i--)
        {
            if (someNum[i] == '1')
            {
                decimalNum += (someNum[i] - '0') * (int)(Math.Pow(s, someNum.Length - 1 - i));
            }
        }

        StringBuilder result = new StringBuilder();
        //Convert to d base number
        while (decimalNum > 0)
        {
            switch (decimalNum % d)
            {
                case 0: result.Append("0"); break;
                case 1: result.Append("1"); break;
                case 2: result.Append("2"); break;
                case 3: result.Append("3"); break;
                case 4: result.Append("4"); break;
                case 5: result.Append("5"); break;
                case 6: result.Append("6"); break;
                case 7: result.Append("7"); break;
                case 8: result.Append("8"); break;
                case 9: result.Append("9"); break;
                case 10: result.Append("A"); break;
                case 11: result.Append("B"); break;
                case 12: result.Append("C"); break;
                case 13: result.Append("D"); break;
                case 14: result.Append("E"); break;
                case 15: result.Append("F"); break;
                default: result.Append(""); break;
            }
            decimalNum = decimalNum / d;
        }
        //Reverse the string
        char[] arr = result.ToString().ToCharArray();
        Array.Reverse(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}