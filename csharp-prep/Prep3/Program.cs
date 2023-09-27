using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.Write("Higher!");
        }
        else if (magicNumber < guess)
        {
            Console.Write("Lower!");
        }
        else 
        {
            Console.Write("You guessed!");
        }


        
    }
}