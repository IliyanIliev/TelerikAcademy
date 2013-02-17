using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> inBinary = new List<int>();
            while (number > 0)
            {
                inBinary.Add(number % 2);
                number = number / 2;
            }
            inBinary.Reverse();
            for (int i = 0; i < inBinary.Count; i++)
            {
                Console.Write("{0} ", inBinary[i]);
            }
            Console.WriteLine();
        }
    }
