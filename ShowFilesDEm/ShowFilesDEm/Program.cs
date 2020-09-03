using System;
using System.IO;

namespace ShowFilesDEm
{
  class Program
  {
    static void ShowDirectory(DirectoryInfo dir)
    {
      // Показать все файлы
      foreach (FileInfo file in dir.GetFiles())
      {
        Console.WriteLine("File: {0}", file.FullName);
      }
      foreach (DirectoryInfo subDir in dir.GetDirectories())
      {
        ShowDirectory(subDir);
      }
    }
    static void watcher_Changed(object sender, FileSystemEventArgs e)
    {
      Console.WriteLine("Changed: {0}", e.FullPath);
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      FileSystemWatcher watcher =
new FileSystemWatcher(Environment.SystemDirectory);
      watcher.Filter = "*.ini";
      watcher.IncludeSubdirectories = true;
      watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
      watcher.Changed +=
      new FileSystemEventHandler(watcher_Changed);


      DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); ShowDirectory(dir);
    }
  }
}
