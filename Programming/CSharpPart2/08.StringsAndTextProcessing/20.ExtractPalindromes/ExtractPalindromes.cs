﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractPalindromes
{
    static void Main()
    {
        string text = @"ABBA lamal exe some lol hah face";
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in splitted)
        {
            bool isPalindrome = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
