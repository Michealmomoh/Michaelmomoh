using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ENTER USER INPUT ");
        string grade = Console.ReadLine();
        int grade_percent = int.Parse(grade);
        string letter = "";
    if(grade_percent >=90)
    {
        letter = "A";
        Console.WriteLine($"Your grade is: {letter}");
    }
    else if( grade_percent >= 80)
    {
        letter = "B";
        Console.WriteLine($"Your grade is: {letter}");
    }
    else if(grade_percent >=70)
    {
        letter = "C";
        Console.WriteLine($"Your grade is: {letter}");
    }
    else if (grade_percent >=60)
    {
        letter = "D";
        Console.WriteLine($"Your grade is: {letter}");
    }
    else if (grade_percent < 60)
    {
        letter = "F";
        Console.WriteLine($"Your grade is: {letter}");
    }
    if (grade_percent >=70){
        Console.WriteLine("You passed!");
    }
    else
    {
        Console.WriteLine("BETTER LUCK NEXT TIME! ");
    }

        Console.WriteLine("Hello Prep2 World!");
    }
}