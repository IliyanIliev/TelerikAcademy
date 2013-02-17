using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double pointX = 2;
            double pointY = 3;
            double circleRadius = 5;
            bool IsInCircle = (pointX*pointX + pointY*pointY <circleRadius*circleRadius);
            Console.WriteLine(IsInCircle);
        }
    }
}
