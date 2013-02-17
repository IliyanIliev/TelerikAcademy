using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConcatFiles
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter("file3.txt");
        using (writer)
        {
            StreamReader firstReader = new StreamReader("file1.txt");
            using (firstReader)
            {
                string a = firstReader.ReadToEnd();
                writer.WriteLine(a);
            }

            StreamReader secondReader = new StreamReader("file2.txt");
            using (secondReader)
            {
                string b = secondReader.ReadToEnd();
                writer.WriteLine(b);
                Console.WriteLine("Done!");
            }

        }
    }
}
