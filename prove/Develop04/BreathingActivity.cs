using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Breathing Activity Welcome Message")
    {
        
    }
    public void BreatheInOut(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            CountdownNumbers("Breathe in...");
            CountdownNumbers("Breathe out...");
        }
    }

    public void RunBreathingActivity()
    {
        Run(BreatheInOut);
    }
}