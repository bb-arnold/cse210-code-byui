using System;

class SimpleGoal : Goal
{
    private string _goalType = "SimpleGoal";

    public SimpleGoal(User user)
    : base (user)
    {
        
    }

    public SimpleGoal(string goalName, string goalDescription, int pointValue, User user)
    : base (goalName, goalDescription, pointValue, user)
    {
        
    }

    public override string SaveGoalText()
    {
        string lineToSave = base.SaveGoalText();

        string lineToAdd = "|" + _complete + "|" + _goalType;
        lineToSave += lineToAdd;

        return lineToSave;
    }

    //Written
    public override void RecordEvent()
    {
        _complete = true;
        AddPoints(_pointValue);
    }
}