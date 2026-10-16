using System;
using System.Security.Cryptography.X509Certificates;

class User
{
    private int _points;
    private List<Goal> _goalList = new List<Goal>();

    //Test Goal
    Goal _testGoal = new Goal();

    public User()
    {
        _points = 0;

        //test goal
        _goalList.Add(_testGoal);
    }

    public void SaveGoals()
    {
        Console.WriteLine("Save goals");
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
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