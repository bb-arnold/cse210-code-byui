using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Fred", "Milk");


        Console.WriteLine(assignment1.GetSummary());
    }
}