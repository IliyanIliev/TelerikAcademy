using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IdenticalLetters
{
    static void Main(string[] args)
    {
        string someStr = "aaaabbbcccddddddd";
        StringBuilder result = new StringBuilder();
        char current = someStr[0];
        result.Append(current);
        for (int i = 1; i < someStr.Length; i++)
        {
            if (current != someStr[i])
            {
                result.Append(someStr[i]);
                current = someStr[i];
            }
        }
        Console.WriteLine(result.ToString());
    }
}