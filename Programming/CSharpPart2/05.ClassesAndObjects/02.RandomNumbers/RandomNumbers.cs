using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Random rndNum = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}", rndNum.Next(100,201));
        }
    }
}
