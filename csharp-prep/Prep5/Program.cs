using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //test
        DisplayWelcome();
        
        string username = PromptUserName();
        
        int usernumber = PromptUserNumber();

        int bYear;
        PromptUserBirthYear(out bYear);

        usernumber = SquareNumber(usernumber);

        DisplayResult(username , usernumber , bYear);
    }

    //   DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    //   PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();

        return username;
    }

    //   PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int usernumber = int.Parse(Console.ReadLine());

        return usernumber;  
    }

    //     PromptUserBirthYear - Accepts out integer parameter and prompts
    // the user for the year they were born. The out parameter is set 
    // to their birth year. This function does not return a value. The 
    // user's birth year is given back from the function via the out
    // parameter.
    static void PromptUserBirthYear(out int yearVariable)
    {
        Console.Write("Please enter the year you were born: ");
        yearVariable = int.Parse(Console.ReadLine());
    }


    //  SquareNumber - Accepts an integer as a parameter and returns that
    //  number squared (as an integer)
    static int SquareNumber(int number)
    {
        int number2 = number * number;
        return number2;
    }

    //     DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years 
    //  old they will turn this year and display that.
    static void DisplayResult(string username , int numberSquared , int birthYear)
    {
        Console.WriteLine($"{username}, the square or your favorite number is {numberSquared}.");
        int age = 2026 - birthYear;
        Console.WriteLine($"{username}, you will turn {age} this year.");
    }
}