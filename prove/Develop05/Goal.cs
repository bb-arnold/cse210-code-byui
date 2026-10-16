using System;

class Goal
{
    string _goalName = "No set name.";
    bool _complete = false;
    string _goalDiscription = "No description";
    int _pointValue = 0;

    public Goal()
    {
        
    }

    public Goal(string goalName, string goalDiscription, int pointValue)
    {
        _goalName = goalName;
        _goalDiscription = goalDiscription;
        _pointValue = pointValue;
    }

    public virtual string DisplayGoal()
    {
        string goalDiplay = "";

        if (_complete)
        {
            goalDiplay += "[x]";
        }
        else
        {
            goalDiplay += "[ ]";
        }
        
        goalDiplay += $"{_goalName} ({_goalDiscription})";

        return goalDiplay;
    }

    public string SaveGoal()
    {
        return "goal.Save Goal";
    }

    public void RecordEvent()
    {
        Console.WriteLine("goal.RecordEvent");
    }

    public void UserGoalInput()
    {
        Console.WriteLine("goal.UserGoalInput");
    }

    public void AddPoints(int points)
    {
        Console.WriteLine("goal.addpoints");
    }


}