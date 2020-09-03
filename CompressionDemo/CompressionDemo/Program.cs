using System;
using System.IO;

namespace CompressionDemo
{
  class Program
  {
    static void CompressFile(string inFilename,
string outFilename)
    {
      GZipStream compStream =
new GZipStream(destFile, CompressionMode.Compress);
      int theByte -sourceFile.ReadByte();
      while (theByte != -1)
      {
        compStream.WriteByte((byte)theByte); theByte = sourceFile.ReadByte();
      }
    }

    static void Main(string[] args)
    {
      
      CompressFile(@"c:\boot.ini", @"с:\boot.ini.gz");
      Console.WriteLine("Hello World!");
    }
  }
}
