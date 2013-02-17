using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Tubes
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        long[] tubes = new long[N];
        long sum = 0;
        for (int i = 0; i < N; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());
            sum += tubes[i];
        }
        if (sum < M)
        {
            Console.WriteLine(-1);
            return;
        }
        long l = 1;
        long r = int.MaxValue;

        while (l + 1 < r)
        {
            long m = (l + r) / 2;
            long many = 0;
            for (int i = 0; i < N; i++)
            {
                many += tubes[i] / m;
            }
            if (many >= M) l = m;
            else r = m;
        }
        Console.WriteLine(l);
    }
}