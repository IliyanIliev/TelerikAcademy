using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CountRepeatingWordsAndSort
{
    static void Main(string[] args)
    {
        try
        {
            string wordsPath = "words.txt";
            string textPath = "test.txt";
            string[] words = File.ReadAllLines(wordsPath);
            int[] values = new int[words.Length];
            using (StreamReader reader = new StreamReader(textPath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                    }

                    line = reader.ReadLine();
                }
            }
            //Sort a pair of arrays
            Array.Sort(values, words);

            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--) // Descending order
                    output.WriteLine("{0}: {1}", words[i], values[i]);
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
