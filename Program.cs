using System;

// Assignment 3.1 Twitter
// By Addison Roy
class Program
{
    static void Main()
    {
        Console.Write("Simple Tweet length verifier\n");
        Console.Write("Enter your message: ");
        string message = Console.ReadLine();

        if (message.Length <= 140)
        {
            Console.WriteLine("This Tweet can be posted (Posted)");
        }
        else
        {
            Console.WriteLine("This Tweet is too long for twitter (Rejected)");
                goto start;
        }
    }
}

