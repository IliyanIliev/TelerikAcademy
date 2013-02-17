using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOutRectInCircle
{
    class PointOutRectInCircle
    {
        static void Main(string[] args)
        {
            double pointX = 2;
            double pointY = -1;
            double circleRadius = 5;
            double circleX=1;
            double circleY=1;
            bool IsInCircle = ((pointX-circleX) * (pointX-circleX) + (pointY-circleY) * (pointY-circleY) < circleRadius * circleRadius);
            bool IsInRect = ((pointX>=-1 && pointX<=5) && (pointY>=1 && pointY<=3));
            bool OutRectInCircle = (IsInCircle==true && IsInRect==false);
            Console.WriteLine(OutRectInCircle);
        }
    }
}
