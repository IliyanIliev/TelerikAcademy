using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalcSumOfSequence
{
    static void Main(string[] args)
    {
        string sequence = "5 15 6 18 4 9 10.5";
        sequence = sequence.Trim();
        string[] arrNums = sequence.Split(' ');
        double sumOfNums = 0;
        for (int i = 0; i < arrNums.Length; i++)
        {
            sumOfNums += double.Parse(arrNums[i].Trim());
        }

        Console.WriteLine("The sum of the sequence is {0}",sumOfNums);
    }
}
