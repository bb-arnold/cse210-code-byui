using System;
using System.Security.Cryptography.X509Certificates;

class User
{
    int _points;

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

    public void PrintPoints()
    {
        Console.WriteLine("print points");
        Console.WriteLine(_points);
    }

//fully written
    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
}