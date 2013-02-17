using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DifferentWords
{
    static void Main(string[] args)
    {
        string someStr = "arghh hi lol hi hi arghh";
        string[] allWords = someStr.Split(' ');


        Dictionary<string, int> words = new Dictionary<string, int>();
        for (int i = 0; i < allWords.Length; i++)
        {
            allWords[i] = allWords[i].Trim();
            if (allWords[i].Length>0)
            {
                if (!words.ContainsKey(allWords[i]))
                {
                    words.Add(allWords[i], 1);
                }
                else
                {
                    words[allWords[i]]++;
                }
            }
        }

        foreach (KeyValuePair<string, int> pair in words)
        {
            Console.WriteLine("{0} - {1}",
            pair.Key,
            pair.Value);
        }
    }
}