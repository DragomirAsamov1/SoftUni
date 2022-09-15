using System;
using System.IO;

namespace CopyBinaryFile {
    internal class Program {
        static void Main(string[] args) {
            using (FileStream reader = new FileStream("../../../random.png", FileMode.Open)) {
                using (FileStream writer = new FileStream("../../../newImage.png", FileMode.Create, FileAccess.Write)) {
                    byte[] buffer = new byte[1];
                    long count = 0;

                    while (count < reader.Length) {
                        reader.Read(buffer, 0, buffer.Length);
                        writer.Write(buffer, 0, buffer.Length);
                        count += buffer.Length;
                    }
                }
            }
        }
    }
}
