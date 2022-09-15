using System;
using System.IO;

namespace FolderSize {
    internal class Program {
        static void Main(string[] args) {
            string folderPath = "../../../FolderSize";

            double memory = ScanFolderRecursively(folderPath) / 1024.0 / 1024.0;
            Console.WriteLine(memory);
        }

        static double ScanFolderRecursively(string folderPath) {

            var files = Directory.GetFiles(folderPath);

            double fileSizes = 0;

            foreach (var filePath in files) {
                FileInfo file = new FileInfo(filePath);

                fileSizes += file.Length;
            }

            var directories = Directory.GetDirectories(folderPath);

            foreach (var directory in directories) {
                fileSizes += ScanFolderRecursively(directory);
            }

            return fileSizes;
        }
    }
}
