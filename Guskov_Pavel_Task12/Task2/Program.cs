using System;
using System.IO;

namespace Task2
{
    class Program
    {
        const string sourcePath = @"C:\Projects\.NET_2018-2_GuskovPA\Guskov_Pavel_Task12\Folder";
        const string backupPath = @"C:\Projects\.NET_2018-2_GuskovPA\Guskov_Pavel_Task12\Backup";

        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Start watching the folder");
            Console.WriteLine("2 - Return backup");

            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(sourcePath);

                fileSystemWatcher.Changed += OnChange;
                fileSystemWatcher.Created += OnChange;
                fileSystemWatcher.Deleted += OnChange;

                fileSystemWatcher.IncludeSubdirectories = true;
                fileSystemWatcher.EnableRaisingEvents = true;

                Console.WriteLine("Watching the folder on");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the date and time, when you saved folder, in format dd-mm-yy hh.mm.ss(21-12-18 20.30.17)");

                string date = Console.ReadLine();
                string path = Path.Combine(backupPath, date);

                if (Directory.Exists(path))
                {
                    DirManager.DeleteFolder(sourcePath);
                    DirManager.BackupFolder(path, sourcePath);
                }
                Console.WriteLine("Executed");
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }

            Console.ReadKey();
        }

        static void OnChange(object sender, FileSystemEventArgs e)
        {
            DirManager.BackupFolder(sourcePath, Path.Combine(backupPath, DateTime.Now.ToString("dd-MM-yy HH.mm.ss")));
        }
    }
}
