using System;

class ExceptionTest
{
    static void Main()
    {
        int age;
        try
        {
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank You");
        }
        catch (Exception e)
        {
            //Get the error message out of the exception
            Console.WriteLine(e.Message);
        }
    }
}