using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserChoice
{
    class UserChoice
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double result;
            bool stringValue = Double.TryParse(input, out result); //We check if its an integer
            switch (stringValue)
            {
                case true: Console.WriteLine(result + 1); break; // If it is we add 1
                case false: Console.WriteLine("{0}*", input); break; // If it's not we add an *
                default: Console.WriteLine("What?");break;
            }
        }
    }
}
