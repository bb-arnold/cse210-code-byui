using System;
using System.Security.Cryptography.X509Certificates;

class User
{
    private int _points;
    private List<Goal> _goalList = new List<Goal>();

    public User()
    {
        _points = 0;
    }

    public void SaveGoals()
    {
        Console.WriteLine("Save goals");
    }

    //written
    public void DisplayGoals()
    {
        Console.WriteLine();
        Console.WriteLine("The Goals are:");

        foreach (Goal goal in _goalList)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    //written partially - inputs 1 and 2 are functional
    public void UserCreateGoal()
    {
        Console.WriteLine("  The types of Goals are: ");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("  Which type of goal would you like to create? ");

        try
        {
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                SimpleGoal simplegoal = new SimpleGoal(this);
                _goalList.Add(simplegoal);

                _goalList[_goalList.Count() - 1].UserGoalInput();
            }
            else if (input == 2)
            {
                EternalGoal Eternalgoal = new EternalGoal(this);
                _goalList.Add(Eternalgoal);

                _goalList[_goalList.Count() - 1].UserGoalInput();                
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number given in the menu.");
        }
        
    }

    public void LoadGoals()
    {
        Console.WriteLine("Load goals");
    }

    //written
    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("  The goals are: ");

        int i = 1;
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }

        Console.Write("Which goal did you accomplish? ");
        try
        {
        _goalList[int.Parse(Console.ReadLine()) - 1].RecordEvent();
        }
        catch (FormatException)
        {
            
        }
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