using System;

class BreathingActivity : Activity
{
    public BreathingActivity() 
    : base("Breathing Activity", 
           "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    private void BreatheInOut(int duration)
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