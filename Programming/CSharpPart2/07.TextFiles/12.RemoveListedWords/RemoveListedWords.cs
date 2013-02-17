using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class RemoveListedWords
{
    static void Main(string[] args)
    {
        try
        {
            string words = String.Join("|", File.ReadAllLines("words.txt"));
            string regex = @"\b(" + words + @")\b";

            using (StreamReader input = new StreamReader("input.txt"))
            {
                using (StreamWriter output = new StreamWriter("output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                        output.WriteLine(Regex.Replace(line, regex, String.Empty));
                }
            }
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}