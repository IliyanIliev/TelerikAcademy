using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DeleteOddLines
{
    static void Main(string[] args)
    {
        string path = @"someFile.txt";
        List<string> lines = new List<string>();
        int counter = 1;
        using (StreamReader reader = new StreamReader(path))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (counter % 2 != 0)
                {
                    lines.Add(line);
                }
                line = reader.ReadLine();
                counter++;
            }
        }

        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (var item in lines)
            {
                writer.WriteLine(item);
            }
        }
    }
}
