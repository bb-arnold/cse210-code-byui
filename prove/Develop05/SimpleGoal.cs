using System;

class SimpleGoal : Goal
{
    public SimpleGoal(User user)
    : base (user)
    {
        
    }

    public SimpleGoal(string goalName, string goalDescription, int pointValue, User user)
    : base (goalName, goalDescription, pointValue, user)
    {
        
    }

    public override string SaveGoal()
    {
        return "simple goal save goal nw";
    }

    //Written
    public override void RecordEvent()
    {
        _complete = true;
        AddPoints(_pointValue);
    }
}