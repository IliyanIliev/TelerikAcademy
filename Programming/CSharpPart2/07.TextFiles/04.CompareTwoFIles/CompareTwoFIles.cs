using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareTwoFIles
{
    static void Main(string[] args)
    {
        string firstFilePath = @"firstFile.txt";
        string secondFilePath = @"secondFile.txt";
        int count = 0;
        int equal = 0;

        using (StreamReader firstFileReader = new StreamReader(firstFilePath))
        {
            using (StreamReader secondFileReader = new StreamReader(secondFilePath))
            {    
                string firstFileLine = firstFileReader.ReadLine();
                string secondFileLine = secondFileReader.ReadLine();
                while (firstFileLine != null || secondFileLine != null)
                {
                    if (firstFileLine == secondFileLine)
                    {
                        equal++;
                    }
                    count++;
                    firstFileLine = firstFileReader.ReadLine();
                    secondFileLine = secondFileReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Equal lines: {0}",equal);
        Console.WriteLine("Different lines: {0}",count-equal);
    }
}