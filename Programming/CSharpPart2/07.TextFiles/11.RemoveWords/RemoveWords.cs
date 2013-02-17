using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class RemoveWords
{
    static void Main(string[] args)
    {
        string path = @"file.txt";
        string pattern = @"\btest?[a-zA-z0-9]+";
        string content = "";
        using (StreamReader reader = new StreamReader(path))
        {
            string input = reader.ReadToEnd();
            content = Regex.Replace(input, pattern, String.Empty);
        }

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine(content);
        }
    }
}