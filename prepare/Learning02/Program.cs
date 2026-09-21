using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Init new objects, set their variables
        Job job1 = new Job();
        Job job2 =  new Job();

        job1._company = "Chase Is awesome";
        job2._company = "bananas";

        Console.WriteLine($"{job1._company}, {job2._company}");
        
    }
}