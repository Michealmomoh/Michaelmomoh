using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        
        string userName = PromptUserName();

        
        int userNumber = PromptUserNumber();

        
        int squaredNumber = SquareNumber(userNumber);

        
        DisplayResult(userName, squaredNumber);
    }

    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string PromptUserName = Console.ReadLine();
        Console.WriteLine(PromptUserName);
        return PromptUserName;
    }

    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    
    static void DisplayResult(string PromptUserName, int SquareNumber)
    {
        Console.WriteLine($"{PromptUserName}, the square of your number is {SquareNumber}");
        
    }
    
}