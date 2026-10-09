using System;
using System.ComponentModel;

class ReflectingActivity : Activity
{
    public ReflectingActivity() 
    : base("Reflecting Activity",
           "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    private List<string> _prompts = ["Think of a time when you stood up for someone else",
                             "Think of a time when you did something really difficult.",
                             "Think of a time when you helped someone in need.",
                             "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?",
                               "Have you ever done anything like this before?",
                               "How did you get started?",
                               "How did you feel when it was complete?",
                               "What made this time different than other times when you were not as successful?",
                               "What is your favorite thing about this experience?",
                               "What could you learn from this experience that applies to other situations?",
                               "What did you learn about yourself through this experience?",
                               "How can you keep this experience in mind in the future?"];

    private void SituationReflection(int duration)
    {
        string randomQuestion = RandomStringFromList(_questions);
        string randomPrompt = RandomStringFromList(_prompts);

        Console.WriteLine("Considor the following prompt:");
        Console.WriteLine();

        //choose a random prompt from prompts and print it
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine();

        //continue when enter is pressed
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        //instructions with number countdown
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        CountdownNumbers("You may begin in:", 5);

        //clear console
        Console.Clear();

        //print random questions with formatting and spinner each time the spinner is done
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            CountdownSpinner($"> {randomQuestion}", 10, "same");

            //reset random question with a new random question
            randomQuestion = RandomStringFromList(_questions);
        }
    }

    public void RunReflectingActivity()
    {
        Run(SituationReflection);
    }
}