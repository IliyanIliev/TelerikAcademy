using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCastToString
{
    class ObjectCastToString
    {
        static void Main(string[] args)
        {
            string strOne = "Hello";
            string strTwo = "World!";
            object helloWorld;
            helloWorld = strOne + " " + strTwo;
            string strThree = helloWorld.ToString();
            Console.WriteLine(strThree);
        }
    }
}
