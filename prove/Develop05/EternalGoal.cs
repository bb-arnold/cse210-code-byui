using System;

class EternalGoal : Goal
{
    public EternalGoal(User user)
    : base (user)
    {
        
    }

    public EternalGoal(string goalName, string goalDescription, int pointValue, User user)
    : base (goalName, goalDescription, pointValue, user)
    {
        
    }

    public override string SaveGoal()
    {
        return "simple goal save goal nw";
    }

    public override void RecordEvent()
    {
        AddPoints(_pointValue);
    }

}