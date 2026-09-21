using System;
using System.ComponentModel;

class Resume
{
/*Class: Resume

    Responsibilities:
        Keeps track of the person's name and a list of their jobs.

    Behaviors:
        Displays the resume, which shows the name first, followed by displaying each one of the jobs.
    */

    //create variables
    public string _name;
    public List<Job> _jobs = new List<Job>();


    public void DisplayResume()
    {
        /*This displays all information on the resume in this format:
        Name: _name
        Jobs:
        _jobs[0].DisplayJobDetails()
        _jobs[1].DisplayJobDetails()
        ...
        */
        
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}