using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNullVars
{
    class PrintNullVars
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.Write("{0} {1}", nullInt, nullDouble);
        }
    }
}
