using System;
using System.IO;
using System.Linq;

namespace MoveVideoFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var directory = @"C:\Users\sstal\Downloads";

            if (Environment.MachineName == "MYSERVER")
            {
                directory = @"F:\ServerFolders\Videos\TV Shows";
            }

            var files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
            var fileExtensions = files.Select(Path.GetExtension)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            foreach (var fileExtension in fileExtensions)
            {
                Console.WriteLine(fileExtension);
            }

            Console.ReadKey();
        }
    }
}