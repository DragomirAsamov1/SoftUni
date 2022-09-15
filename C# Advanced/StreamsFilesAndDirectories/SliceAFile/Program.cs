using System;
using System.IO;

namespace SliceAFile {
    internal class Program {
        static void Main(string[] args) {

            using (FileStream reader = new FileStream("../../../input.txt", FileMode.Open)) {
                int pieceSize = (int)reader.Length / 4;

                for (int i = 0; i < 4; i++) {
                    long count = 0;

                    using (FileStream writer = new FileStream($"../../../Part-{i+1}.txt", FileMode.Create, FileAccess.Write)) {
                        byte[] buffer = new byte[1];

                        while (count < pieceSize) {                            
                            reader.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
