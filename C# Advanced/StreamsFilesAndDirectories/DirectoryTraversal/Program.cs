using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal {
    internal class Program {
        static void Main(string[] args) {
            string[] files = Directory.GetFiles("../../../");

            string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            
            FileInfo[] filesArr = new FileInfo[files.Length];
            
            int index = 0;
            foreach (var filepath in files) {
                FileInfo file = new FileInfo(filepath);
                filesArr[index] = file;
                index++;
            }

            Dictionary<string, FileInfo[]> map = filesArr.GroupBy(x => x.Extension).ToDictionary(x => x.Key, x => x.ToArray());

            using (StreamWriter writer = new StreamWriter($"{destinationPath}/report.txt")) {

                foreach (var extension in map.OrderByDescending(x => x.Value.Length).ThenBy(x => x.Key)) {
                    writer.WriteLine(extension.Key);
                    foreach (var file in extension.Value.OrderBy(x => x.Length)) {
                        writer.WriteLine($"--{file.Name} - {Math.Round(file.Length / 1024.0, 3)}kB");
                    }
                }
            }
        }
    }
}
