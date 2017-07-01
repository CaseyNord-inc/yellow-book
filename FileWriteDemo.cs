using System;
using System.IO;

class FileWriteDemo
{
    public static void Main()
    {
        StreamWriter writer;
        writer = new StreamWriter("test.txt");
        writer.WriteLine("Hello World");
        writer.Close();
    }
}