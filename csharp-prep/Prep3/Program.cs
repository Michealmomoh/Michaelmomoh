using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO GUESS NUMBER");
        Console.Write("Enter the magic number: ");
        int guess_number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Guess the number: ");
        int userGuess = Convert.ToInt32(Console.ReadLine());
        

    if (userGuess < guess_number){
        Console.WriteLine("GUESS HIGHER");
    }
    else if(userGuess > guess_number){
        Console.WriteLine("guess lower");
    }

    else
    {
        Console.WriteLine("Congratulations! You guessed the magic number!");
    }

    
    }
}