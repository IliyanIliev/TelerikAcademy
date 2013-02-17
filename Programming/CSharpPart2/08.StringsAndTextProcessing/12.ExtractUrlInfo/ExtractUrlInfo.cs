using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractUrlInfo
{
    static void Main(string[] args)
    {
        string someURL = @"http://www.devbg.org/forum/index.php";

        var fragments = Regex.Match(someURL, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine("[protocol] = {0}",fragments[1]);
        Console.WriteLine("[server] = {0}",fragments[2]);
        Console.WriteLine("[resource] = {0}",fragments[3]);
    }
}
