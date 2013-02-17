using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DifferentLetters
{
    static void Main(string[] args)
    {
        string someStr = "asdsa fsderger gregerge";

        Dictionary<char,int> letters = new Dictionary<char, int>();
        for (int i = 0; i < someStr.Length; i++)
        {
            if ((someStr[i]>='a' && someStr[i]<='z') || (someStr[i]>='A' && someStr[i]<='Z'))
            {
                if (!letters.ContainsKey(someStr[i]))
                {
                    letters.Add(someStr[i], 1);
                }
                else
                {
                    letters[someStr[i]]++;
                }
            }
        }

        foreach (KeyValuePair<char, int> pair in letters)
        {
            Console.WriteLine("{0} - {1}",
            pair.Key,
            pair.Value);
        }
    }
}