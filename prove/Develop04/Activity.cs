using System;

class Activity
{
    int _duration;
    string _activityName ;
    string _welcomeMessage;

    public Activity(string activityName, string welcomeMessage) //Change this to protected
    {
        _duration = 0;
        _activityName = activityName;
        _welcomeMessage = welcomeMessage;
    }

//Change these to protected
    public void CountdownSpinner( string message, int time, string line = "new")
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

    public void CountdownNumbers(string message, int time = 6, string line = "same")
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

    public int StartMessage()
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
        
    }

    protected void GetDuration()
    {
        
    }

    protected void SetDuration()
    {
        
    }

    public void Run(Action functionToRun)
    {
        
    }
}