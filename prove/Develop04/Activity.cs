using System;
using System.Runtime.CompilerServices;

class Activity
{
    int _duration = 0;
    string _activityName ;
    string _welcomeMessage;

    protected Activity(string activityName, string welcomeMessage)
    {
        _duration = 0;
        _activityName = activityName;
        _welcomeMessage = welcomeMessage;
    }

    protected void CountdownSpinner( string message, int time, string line = "new")
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

    protected void CountdownNumbers(string message, int time = 4, string line = "same")
    {
        if (line == "same")
        {
            Console.Write(message);
            Console.Write(" ");
        }
        else
        {
            Console.WriteLine(message);
        }   

        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    protected int StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();

        Console.WriteLine(_welcomeMessage);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        return int.Parse(Console.ReadLine());
    }

    protected void EndMessage()
    {
        Console.WriteLine();
        CountdownSpinner("Well Done!!", 3);

        CountdownSpinner($"You have completed another {_duration} seconds of the {_activityName}", 5);
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }

    protected void Run(Action<int> functionToRun)
    {
        _duration = StartMessage();
        Console.Clear();

        CountdownSpinner("Get ready...", 3);
        Console.WriteLine();

        functionToRun(_duration);
        EndMessage();
        Console.Clear();
    }
}