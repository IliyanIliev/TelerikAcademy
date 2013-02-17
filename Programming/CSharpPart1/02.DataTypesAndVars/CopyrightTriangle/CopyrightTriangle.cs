using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyrightTriangle
{
    class CopyrightTriangle
    {
        static void Main(string[] args)
        {
            char myChar;
            myChar = '\u00a9';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(@"
     {0}
   {0}  {0}
  {0}    {0}
 {0} {0} {0} {0}", myChar);
        }
    }
}
