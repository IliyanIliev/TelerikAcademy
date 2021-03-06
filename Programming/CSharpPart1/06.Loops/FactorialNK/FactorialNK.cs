﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNK
{
    class FactorialNK
    {
        public static int calcFact(int num)
        {
            int fact=1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            Console.WriteLine("N!/K! = {0}",calcFact(N)/calcFact(K));
        }
    }
}
