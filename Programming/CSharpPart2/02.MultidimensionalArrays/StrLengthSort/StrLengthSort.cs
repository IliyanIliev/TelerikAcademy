using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrLengthSort
{
    class StrLengthSort
    {
        static void Main()
        {
            string[] unsortedStrings = { "b", "aabbaaa", "aadsdwd", "a", "1256s", "wdasdwe" };
            //Using lambda functions
            foreach (var item in unsortedStrings.OrderBy(uStrings => uStrings.Length))
            {
                Console.WriteLine(item);
            }
        }
    }
}
