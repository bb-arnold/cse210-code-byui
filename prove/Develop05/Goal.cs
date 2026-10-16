using System;

abstract class Goal
{
    private string _goalName = "No set name.";
    protected bool _complete = false;
    private string _goalDiscription = "No description";
    protected int _pointValue = 0;
    User _user = new User();

    public Goal(User user)
    {
      _user = user;  
    }

    public Goal(string goalName, string goalDiscription, int pointValue, User user)
    {
        _goalName = goalName;
        _goalDiscription = goalDiscription;
        _pointValue = pointValue;
        _user = user;
    }

    //written
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
        
        goalDiplay += $" {_goalName} ({_goalDiscription})";

        return goalDiplay;
    }

    public abstract string SaveGoal();

    public abstract void RecordEvent();

    //Written
    public virtual void UserGoalInput()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("Give a short description of it: ");
        _goalDiscription = Console.ReadLine();

        Console.Write("What is the number of points associated with this goal? ");

        try 
        {
            _pointValue = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            
        }
    }

    //written
    public void AddPoints()
    {
        _user.SetPoints(_user.GetPoints() + _pointValue);
    }

    //Written
    public string GetName()
    {
        return _goalName;
    }


}