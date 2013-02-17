using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        string binaryNum = Console.ReadLine();
        int decimalNum = 0;
        for (int i = binaryNum.Length-1; i >=0; i--)
        {
            if (binaryNum[i] == '1')
            {
                decimalNum += (binaryNum[i]-'0') * (int)(Math.Pow(2, binaryNum.Length-1-i));
            }
        }

        Console.WriteLine("{0}",decimalNum);
    }
}
