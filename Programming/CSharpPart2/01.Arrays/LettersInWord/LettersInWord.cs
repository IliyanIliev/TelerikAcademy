using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInWord
{
    class LettersInWord
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); //Read the word from the console
            word = word.ToLower(); //make all letters lower
            char[] letters = new char[27];

            //Fill the array
            for (int i = 1; i < 27; i++)
            {
                letters[i] = (char)('a' + i - 1);
            }

            int position;
            //Check letter position
            for (int i = 0; i < word.Length; i++)
            {
                for (position = 1; position <= letters.Length; position++)
                {
                    if (word[i] == letters[position])
                    {
                        break;
                    }
                }

                Console.WriteLine("The letter {0} index is equal to {1}", word[i], position);
            }

        }
    }
}
