using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            var expression = Console
                .ReadLine()
                .Split()
                .Reverse()
                .ToList();

            var stack = new Stack<string>(expression);

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if (symbol == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else if (symbol == "-")
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
                else if (symbol == "*")
                {
                    stack.Push((firstNumber * secondNumber).ToString());
                }
                else if (symbol == "/")
                {
                    stack.Push((firstNumber / secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    
    }
}
