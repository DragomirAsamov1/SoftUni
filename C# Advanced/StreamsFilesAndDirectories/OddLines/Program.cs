﻿using System;
using System.IO;

namespace OddLines {
    internal class Program {
        static void Main(string[] args) {

            

            using (StreamReader reader = new StreamReader("../../../input.txt")) {
                int counter = 0;

                string line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../output.txt")) {
                    while (line != null) {
                        if (counter % 2 == 1) {
                            writer.WriteLine(line);
                        }

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
