using System;
using System.ComponentModel;

class ListingActivity : Activity
{
    public ListingActivity() 
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    List<string> _prompts = ["Who are people that you appreciate?",
                             "What are personal strengths of yours?",
                             "Who are people that you have helped this week?",
                             "When have you felt the Holy Ghost this month?",
                             "Who are some of your personal heroes?"];
    int _answersCount = 0;
    private void ListAnswers(int duration)
    {
        //reset variables
        string randomPrompt = RandomStringFromList(_prompts);
        _answersCount = 0;

        //instructions
        Console.WriteLine("List as many responses as you can to the following prompt:");

        //print random prompt
        Console.WriteLine($"--- {randomPrompt} ---");

        //you may begin countdown
        CountdownNumbers("You may begin in:", 3, "same");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration); 

        //> and read line in while loop, count each time they enter something
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _answersCount ++;
        }

        //inform how many things they entered
        Console.WriteLine($"You listed {_answersCount} items!");
    }

    public void RunListingActivity()
    {
        Run(ListAnswers);
    }

}