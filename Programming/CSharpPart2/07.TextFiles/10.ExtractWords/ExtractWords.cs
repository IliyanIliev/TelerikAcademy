using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractWords
{

    static void Main(string[] args)
    {
        string path = @"file.txt";
        string pattern = @"<[^<]+?>";
        using (StreamReader reader = new StreamReader(path))
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                string input = reader.ReadToEnd();
                string content = Regex.Replace(input, pattern, "");
                writer.WriteLine(content);
            }
        }
    }
}