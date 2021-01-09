﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(expression.Reverse());

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((firstNumber + secondNumber).ToString());
                        break;
                    case "-":
                        stack.Push((firstNumber - secondNumber).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
