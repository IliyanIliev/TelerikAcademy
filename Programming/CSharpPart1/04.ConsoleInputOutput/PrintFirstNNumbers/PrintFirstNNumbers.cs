using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstNNumbers
{
    class PrintFirstNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int someNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= someNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
