using System;

class Activity
{
    int _duration;
    string _activityName;
    string _welcomeMessage;


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
    }

    protected void CountdownNumbers()
    {
        
    }

    protected void StartMessage()
    {
        
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