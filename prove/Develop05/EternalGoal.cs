using System;

class EternalGoal : Goal
{
    string _goalType = "EternalGoal";
    public EternalGoal(User user)
    : base (user)
    {
        
    }

    public EternalGoal(string goalName, string goalDescription, int pointValue, User user)
    : base (goalName, goalDescription, pointValue, user)
    {
        
    }

    public override string SaveGoalText()
    {
        string lineToSave = base.SaveGoalText();
        
        string lineToAdd = "|" + _goalType;
        lineToSave += lineToAdd;

        return lineToSave;
    }

    public override void RecordEvent()
    {
        AddPoints(_pointValue);
    }

}