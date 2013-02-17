using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main(string[] args)
    {
        string expression = @")((a+b)/5-d)";
        int openBrackets = 0;
        int closeBrackets = 0;
        bool correct = true;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i]=='(')
            {
                openBrackets++;
            }
            else if (expression[i] == ')')
            {
                closeBrackets++;
                if (closeBrackets>openBrackets)
                {
                    correct = false;
                    break;
                }
                else if(closeBrackets==openBrackets)
                {
                    closeBrackets = 0;
                    openBrackets = 0;
                }
                else
                {
                    closeBrackets--;
                    openBrackets--;
                }
            }
        }

        if (correct == true)
        {
            if (openBrackets == 0 && closeBrackets == 0)
            {
                Console.WriteLine("Brackets are put correctly!");
            }
            else
            {
                Console.WriteLine("Brackets are put wrongly!");
            }
        }
        else
        {
            Console.WriteLine("Brackets are put wrongly!");
        }

    }
}
