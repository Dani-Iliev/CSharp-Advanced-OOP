using System;
using System.Collections.Generic;

namespace _04_MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int currentIndex = i;
                    int openingBracket = stack.Pop();

                    string subString = expression.Substring(openingBracket, currentIndex - openingBracket + 1);
                    Console.WriteLine(subString);
                }
            }
        }
    }
}
