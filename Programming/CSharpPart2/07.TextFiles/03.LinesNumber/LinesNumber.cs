using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LinesNumber
{
    static void Main(string[] args)
    {
        string path = @"someFile.txt"; //The path to the file
        StreamReader reader = new StreamReader(path);

        using (StreamWriter writer = new StreamWriter("linesFile.txt"))
        {
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(counter + ". " + line);
                    line = reader.ReadLine();
                    counter++;
                }
            }
            Console.WriteLine("Done!");
        }

    }
}
