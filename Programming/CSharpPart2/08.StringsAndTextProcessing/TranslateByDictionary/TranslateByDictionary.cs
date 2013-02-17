using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TranslateByDictionary
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string dictionary =
@".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";

        string[] lines = dictionary.Split('\n');
        string[] terms = new string[lines.Length];
        string[] descs = new string[lines.Length];
        int j = 0;
        foreach (var item in lines)
        {
            string[] temp = item.Split('–');
            terms[j] = temp[0].Trim();
            descs[j] = temp[1].Trim();
            j++;
        }

        for (int i = 0; i < terms.Length; i++)
        {
            if (terms[i] == input)
            {
                Console.WriteLine("{0}",descs[i]);
                break;
            }
        }

    }
}