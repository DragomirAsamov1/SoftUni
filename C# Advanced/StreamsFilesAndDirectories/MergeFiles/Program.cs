using System;
using System.IO;

namespace MergeFiles {
    internal class Program {
        static void Main(string[] args) {
            using (StreamReader reader1 = new StreamReader("../../../input1.txt")) {
                using (StreamReader reader2 = new StreamReader("../../../input2.txt")) {
                    string line1 = reader1.ReadLine();
                    string line2 = reader2.ReadLine();

                    using (StreamWriter writer = new StreamWriter("../../../output.txt")) {

                        while (line1 != null || line2 != null) {

                            if (line1 != null) {
                                writer.WriteLine(line1);
                            }

                            if (line2 != null) {
                                writer.WriteLine(line2);
                            }

                            line1 = reader1.ReadLine();
                            line2 = reader2.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
