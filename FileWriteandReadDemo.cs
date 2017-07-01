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
        
        StreamReader reader = new StreamReader("test.txt");
        while(reader.EndOfStream == false)
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
        reader.Close();
    }
}