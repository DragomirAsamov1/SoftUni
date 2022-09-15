﻿using System;
using System.IO;

namespace LineNumbers {
    internal class Program {
        static void Main(string[] args) {
            using (StreamReader reader = new StreamReader("../../../input.txt")) {
                int counter = 1;

                string line = reader.ReadLine();


                using (StreamWriter writer = new StreamWriter("../../../output.txt")) {
                    while (line != null) {
                        writer.WriteLine(counter + ". " + line);

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
