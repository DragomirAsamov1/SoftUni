using System;

namespace ExtractFile {
    internal class Program {
        static void Main(string[] args) {

            char[] separators = new char[] { '\\', '.' };

            string[] path = Console.ReadLine().Split(separators);

            Console.WriteLine("File name: {0}", path[path.Length - 2]);
            Console.WriteLine("File extension: {0}", path[path.Length - 1]);
        }
    }
}
