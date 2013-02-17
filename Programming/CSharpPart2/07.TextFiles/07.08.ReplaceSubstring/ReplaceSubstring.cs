using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        string path = @"someFile.txt";
        using (StreamReader reader = new StreamReader(path))
        {
            using(StreamWriter writer = new StreamWriter("replace.txt"))
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                   // writer.WriteLine(currentLine.Replace("start", "finish")); //Excercise 7
                    writer.WriteLine(Regex.Replace(currentLine, @"\bstart\b", "finish"));
                    currentLine = reader.ReadLine();
                }
            }
        }

    }
}
