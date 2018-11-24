using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DirManager
    {
        public static void BackupFolder(string sourcePath, string backupPath)
        {
            DirectoryInfo directory = new DirectoryInfo(sourcePath);

            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException("Directory is not found!");
            }
            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
            }
            FileInfo[] files = directory.GetFiles();
            foreach (var file in files)
            {
                try
                {
                    file.CopyTo(Path.Combine(backupPath, file.Name), true);
                }
                catch
                {
                    Console.WriteLine("Incorrect file type");
                }
            }
            DirectoryInfo[] dirs = directory.GetDirectories();

            foreach (DirectoryInfo directorys in dirs)
            {
                BackupFolder(directorys.FullName, Path.Combine(backupPath, directorys.Name));
            }

        }

        public static void DeleteFolder(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException("Directory is not found!");
            }
            foreach (var file in directory.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (var dir in directory.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
