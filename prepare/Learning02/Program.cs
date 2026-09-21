using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Init Job objects, set their variables

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2005;
        job1._endYear = 2025;

        Job job2 =  new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2025;
        job2._endYear = 2026;


        //Init Resume Objects, set their variables
        
        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Chase";

        resume1.DisplayResume();
    }
}