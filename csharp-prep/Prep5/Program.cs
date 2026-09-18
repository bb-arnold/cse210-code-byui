using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //test
        DisplayWelcome();

        //test
        string username = PromptUserName();
        Console.WriteLine(username);
    }

    //   DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    //   PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string username = Console.ReadLine();

        return username;
    }

    //   PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

    //     PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. 
    //  This function does not return a value. The user's birth year is given back from the function via the out parameter.

    //  SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

    //     DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years 
    //  old they will turn this year and display that.
}