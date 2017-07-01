using System;

class ArrayDemo
{
    static string readString(string prompt)
    {
        string result;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
        } while (result == "");
        return result;
    }
    
    static int readInt(string prompt, int low, int high)
    {
        int result;
        do
        {
            string intString = readString(prompt);
            result = int.Parse(intString);
        } while ((result<low) || (result > high));
        return result;
    }
    
    public static void Main()
    {
        int [] scores = new int [1000];
        for (int i=0; i<1000; i=i+1)
        {
            // Compiler error here, doesn't recognize readInt?
            scores [i] readInt("Score: ", 0, 1000);
        }
    }
}