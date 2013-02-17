using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintOddLines
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("file.txt");
        int counter = 1;
        using (reader)
        {
            
            string line = reader.ReadLine();
            while (line != null)
            {
                if (counter%2!=0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
                counter++;
            }
        }
    }
}
