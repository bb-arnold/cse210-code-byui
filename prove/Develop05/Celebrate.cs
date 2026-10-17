using System;
using Microsoft.Win32.SafeHandles;

class Celebrate
{
    int _previous500Celebration;
    int _previous1000Celebration;
    public Celebrate(int celebrate500, int celebrate1000)
    {
        _previous1000Celebration = celebrate1000;
        _previous500Celebration = celebrate500;
    }

    public Celebrate()
    {
        _previous1000Celebration = 0;
        _previous500Celebration = 0;
    }
    

    public bool Celebrate500Check(int points)
    {
        int pointIncrease = points - _previous500Celebration;
        
        if (pointIncrease >= 500)
        {
            SmallCelebration($"Congratulations! You have reached {points} points!");

            _previous500Celebration = points;

            return true;
        }

            return false;     
    }

    public bool Celebrate1000Check(int points)
    {
        int pointIncrease = points - _previous1000Celebration;
        
        if (pointIncrease >= 1000)
        {
            LargeCelebration($"Congratulations! You have reached {points} points!");

            _previous1000Celebration = points;
            _previous500Celebration = points;

            return true;
        }

            return false;     
    }

    //method that returns the previous celebration constants that need stored as a combined string

    //method that sets the constants to the input strings

    //large celebration method
    public void LargeCelebration(string message)
    {
        Console.WriteLine();
        PrintLineOfCharacters("-", message);

        Console.WriteLine("\\ * | * /");
        Console.WriteLine(" \\  |  /");
        Console.WriteLine(message);
        Console.WriteLine(" /  |  \\");
        Console.WriteLine("/ * | * \\");

        PrintLineOfCharacters("-", message);
        Console.WriteLine();
        CountdownSpinner("", 3, "same");
    }

    //small celebration method
    public void SmallCelebration(string message)
    {
        Console.WriteLine();
        PrintLineOfCharacters("*", message);

        CountdownSpinner(message, 4, "same");

        PrintLineOfCharacters("-", message);
        Console.WriteLine();
    }

    private void CountdownSpinner( string message, int time, string line = "new")
    {
        List<string> characters = ["\\" , "|", "/", "-"];
        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(time);

        if (line == "new")
        {
            Console.WriteLine(message);
        }
        else
        {
            Console.Write(message);
            Console.Write(" ");
        }
        
        while (DateTime.Now < endtime)
        {
            Console.Write(characters[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= characters.Count())
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    private void PrintLineOfCharacters(string character, string aboveMessage)
    {
        foreach (int i in Enumerable.Range(1, aboveMessage.Length/2))
        {
            Console.Write($" {character}");
        }
        Console.WriteLine();
    }
}
/*
- - - - - - - - - - - - - - - - - - - - - - - -
\ * | * /
 \  |  /
Congratulations!! You have reached 1000 points!
 /  |  \
/ * | * \
- - - - - - - - - - - - - - - - - - - - - - - -
*/