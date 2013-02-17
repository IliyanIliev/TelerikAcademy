using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortStrings
{
    static void Main(string[] args)
    {
        string path = @"someFile.txt";
        var lineCount = File.ReadLines(path).Count();
        string[] strArr = new string[lineCount];
        int counter = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                strArr[counter] = currentLine;
                counter++;
                currentLine = reader.ReadLine();
            }
        }
        Array.Sort(strArr);

        using (StreamWriter writer = new StreamWriter("sorted.txt"))
        {
            for (int i = 0; i < strArr.Length; i++)
			{
                writer.WriteLine(strArr[i]);
			}
            Console.WriteLine("Done!");
        }
    }
}
