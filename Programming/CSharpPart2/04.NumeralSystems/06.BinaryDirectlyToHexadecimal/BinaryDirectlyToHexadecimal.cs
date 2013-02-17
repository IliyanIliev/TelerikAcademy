using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryDirectlyToHexadecimal
{
    static void Main(string[] args)
    {
        string binaryNum = Console.ReadLine();
        StringBuilder hexNum = new StringBuilder();

        for (int i = 4; i < 32; i *= 4)
        {
            if (binaryNum.Length < i)
            {
                string leadingZeros = new String('0', i - binaryNum.Length);
                binaryNum = leadingZeros + binaryNum;
                break;
            }
        }
        for (int i = 0; i < binaryNum.Length; i += 4)
        {
            switch (binaryNum.Substring(i, 4))
            {
                case "0000": hexNum.Append("0"); break;
                case "0001": hexNum.Append("1"); break;
                case "0010": hexNum.Append("2"); break;
                case "0011": hexNum.Append("3"); break;
                case "0100": hexNum.Append("4"); break;
                case "0101": hexNum.Append("5"); break;
                case "0110": hexNum.Append("6"); break;
                case "0111": hexNum.Append("7"); break;
                case "1000": hexNum.Append("8"); break;
                case "1001": hexNum.Append("9"); break;
                case "1010": hexNum.Append("A"); break;
                case "1011": hexNum.Append("B"); break;
                case "1100": hexNum.Append("C"); break;
                case "1101": hexNum.Append("D"); break;
                case "1110": hexNum.Append("E"); break;
                case "1111": hexNum.Append("F"); break;
                default: hexNum.Append(""); break;
            }
        }
        Console.WriteLine("0x" + hexNum.ToString());
    }
}
