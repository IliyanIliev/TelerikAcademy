using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadFile
{
    static void ReadThisFile(string path)
    {
        string content = File.ReadAllText(path);
        Console.WriteLine(content);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the full path here: ");
        string path = Console.ReadLine();

        try
        {
            ReadThisFile(path);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
