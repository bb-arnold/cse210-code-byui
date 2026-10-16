using System;
using System.Drawing;

class ChecklistGoal : Goal
{
    string _goalType = "ChecklistGoal";
    private int _timesToComplete;
    private int _timesCompleted;
    private int _pointBonus;
    private User _user;

    public ChecklistGoal(User user)
    : base (user)
    {
        _user = user;
    }

    public ChecklistGoal(string goalName, string goalDescription, int pointValue, int timesToComplete, int timesCompleted, int pointBonus, User user)
    : base (goalName, goalDescription, pointValue, user)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _pointBonus = pointBonus;

        if (_timesCompleted >= _timesToComplete)
        {
            _complete = true;
        }
    }

    //written
    public override string DisplayGoal()
    {
        string goalDisplay = base.DisplayGoal();

        goalDisplay += $" -- Curretly completed: {_timesCompleted}/{_timesToComplete}";

        return goalDisplay;
    }

    public override string SaveGoalText()
    {
        string lineToSave = base.SaveGoalText();
        
        string lineToAdd = "|" + _pointBonus + "|" + _timesToComplete + "|" + _timesCompleted + "|" + _goalType;
        lineToSave += lineToAdd;

        return lineToSave;
    }

    //written
    public override void RecordEvent()
    {
        _timesCompleted ++;

        AddPoints(_pointValue);

        if (_timesCompleted >= _timesToComplete)
        {
            _complete = true;
        }
    }

    //written
    public override void UserGoalInput()
    {
        base.UserGoalInput();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        try 
        {
            _timesToComplete = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            
        }

        Console.Write("What is the bonus for accomplishing it that many times? ");
        try 
        {
            _pointBonus = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            
        }
    }

    public override void AddPoints(int points)
    {
        base.AddPoints(points);

        if (_timesCompleted == _timesToComplete)
        {
            _user.EarnPoints(_pointBonus);
        }
    }
}