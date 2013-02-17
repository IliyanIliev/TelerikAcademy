using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ListOfWords
{
    static void Main(string[] args)
    {
        string listOfWords = "dcb dcd abc ab a";
        string[] words = listOfWords.Split(' ');
        Array.Sort(words);
        string sorted = String.Join(" ", words);

        Console.WriteLine(sorted);

    }
}