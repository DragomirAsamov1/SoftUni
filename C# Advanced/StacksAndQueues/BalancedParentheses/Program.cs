using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses {
    internal class Program {
        static void Main(string[] args) {

            Queue<char> symbols = new Queue<char>(Console.ReadLine().ToCharArray());

            while (symbols.Count > 0) {
                char symbol = symbols.Peek();
                char compareSymbol = symbols.ElementAt(1);

                switch (symbol) {
                    case '{':
                        if (compareSymbol == '}') {
                            symbols.Dequeue();
                            symbols.Dequeue();
                        } else {
                            symbols.Enqueue(symbols.Dequeue());
                        }
                        break;
                    case '[':
                        if (compareSymbol == ']') {
                            symbols.Dequeue();
                            symbols.Dequeue();
                        } else {
                            symbols.Enqueue(symbols.Dequeue());
                        }
                        break;
                    case '(':
                        if (compareSymbol == ')') {
                            symbols.Dequeue();
                            symbols.Dequeue();
                        } else {
                            symbols.Enqueue(symbols.Dequeue());
                        }
                        break;

                }
            }

            Console.WriteLine("YES");
        }
    }
}
