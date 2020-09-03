using System;
using System.IO;

namespace FileDEmo
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamWriter writer = File.CreateText(@"C:\Users\student\source\repos\newfile.txt"); writer.WriteLine("This is my new file");
      writer.WriteLine("Do you like its format?"); writer.Close();
      StreamReader reader = File.OpenText(@"C:\Users\student\source\repos\newfile.txt");
      string contents = reader.ReadToEnd();
      reader.Close();
      Console.WriteLine(contents);
    }
  }
}
