﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace ReverseStrings {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);

            while (stack.Count != 0) {
                Console.Write(stack.Pop());
            }

        }
    }
}
