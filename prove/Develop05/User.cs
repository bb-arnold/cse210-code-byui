using System;
using System.Security.Cryptography.X509Certificates;

class User
{
    private int _points;
    private List<Goal> _goals = new List<Goal>();

    public User()
    {
        _points = 0;
    }

    public void SaveGoals()
    {
        Console.WriteLine("Save goals");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Display goals");
    }

    public void UserCreateGoals()
    {
        Console.WriteLine("User Create goals");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Load goals");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Record event");
    }

    //All below are fully written
    public void PrintPoints()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_points} points.");
        Console.WriteLine();
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
}