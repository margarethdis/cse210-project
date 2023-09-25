using System;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last  = Console.ReadLine(); 
        
        Console.Write("");
        Console.WriteLine($"Your name is {last}, {first} {last}.");

    }
} 
