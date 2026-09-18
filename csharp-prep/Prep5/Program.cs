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

        //test
        int usernumber = PromptUserNumber();
        Console.WriteLine(usernumber);

        //test
        int bYear;
        PromptUserBirthYear(out bYear);
        Console.WriteLine(bYear);
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
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
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
        Console.Write("What is your birth year? ");
        yearVariable = int.Parse(Console.ReadLine());
    }


    //  SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

    //     DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years 
    //  old they will turn this year and display that.
}