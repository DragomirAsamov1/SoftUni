using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract {
    internal class Program {
        static void Main(string[] args) {

            Random r = new Random();
            
            using (ZipArchive archive = ZipFile.Open("../../../zipfile.zip", ZipArchiveMode.Create)) {

                archive.CreateEntry($"emptyfile{r.Next(0, int.MaxValue)}.txt");
            }

            using (ZipArchive test = ZipFile.Open("../../../zipfile.zip", ZipArchiveMode.Update)) {
                test.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));

            }
            File.Delete("../../../zipfile.zip");
        }
    }
}
