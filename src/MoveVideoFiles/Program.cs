using System;
using System.IO;
using System.Linq;

namespace MoveVideoFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parseDirectory = @"C:\Users\sstal\Downloads";

            if (Environment.MachineName == "MYSERVER")
            {
                parseDirectory = @"F:\ServerFolders\Videos\TV Shows";
            }

            var goodExtensions = new[] { ".avi", ".mkv", ".mp4" };
            var files = Directory.GetFiles(parseDirectory, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                var info = new FileInfo(file);

                if (goodExtensions.Contains(Path.GetExtension(file)))
                {
                    if (info.DirectoryName != parseDirectory)
                    {
                        var moveToPath = Path.Combine(parseDirectory, info.Name);

                        Console.WriteLine("Moving: " + info.Name);

                        //info.MoveTo(moveToPath);
                    }
                }
                else
                {
                    Console.WriteLine("Deleting: " + info.Name);

                    //info.Delete();
                }
            }

            Console.ReadKey();
        }
    }
}