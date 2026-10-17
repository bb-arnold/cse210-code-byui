using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using Microsoft.VisualBasic;

class User
{
    private int _points;
    private List<Goal> _goalList = new List<Goal>();

    public User()
    {
        _points = 0;
    }

    //written
    public void SaveGoals(Celebrate celebrate)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter goalsFile = new StreamWriter(filename))
        {
            goalsFile.WriteLine(_points + "|" + celebrate.CelebrateConstantStorageString());

            foreach (Goal goal in _goalList)
            {
                goalsFile.WriteLine(goal.SaveGoalText());
            }
        }
    }

    //written
    public void DisplayGoals()
    {
        Console.WriteLine();
        Console.WriteLine("The Goals are:");

        int i = 1;
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
    }

    //written
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
                SimpleGoal simpleGoal = new SimpleGoal(this);
                _goalList.Add(simpleGoal);

                _goalList[_goalList.Count() - 1].UserGoalInput();
            }
            else if (input == 2)
            {
                EternalGoal eternalGoal = new EternalGoal(this);
                _goalList.Add(eternalGoal);

                _goalList[_goalList.Count() - 1].UserGoalInput();                
            }
            else if (input == 3)
            {
                ChecklistGoal checkListGoal = new ChecklistGoal(this);
                _goalList.Add(checkListGoal);

                _goalList[_goalList.Count() - 1].UserGoalInput();                
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number given in the menu.");
        }
        
    }

    public void LoadGoals(Celebrate celebrate)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] information = line.Split("|");

            if (information[^1] == "SimpleGoal")
            {
                ProgramCreateSimpleGoal(line);
            }
            else if (information[^1] == "EternalGoal")
            {
                ProgramCreateEternalGoal(line);
            }
            else if (information[^1] == "ChecklistGoal")
            {
                ProgramCreateChecklistGoal(line);
            }
            else
            {
                _points = int.Parse(information[0]);
                celebrate.ConstantSetting(int.Parse(information[1]), int.Parse(information[2]));
            }
        }
    }

    //written
    public void RecordEvent()
    {
        int previousPoints = _points;

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
        catch (ArgumentOutOfRangeException)
        {
            
        }

        Console.WriteLine($"Congratulations! you have earned {_points - previousPoints} points!");

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

    public void EarnPoints(int points)
    {
        _points += points;
    }

    private void ProgramCreateSimpleGoal(string infoString)
    {
        string[] information = infoString.Split("|");
        SimpleGoal simpleGoal = new SimpleGoal(information[0], information[1], int.Parse(information[2]), bool.Parse(information[3]), this);
        _goalList.Add(simpleGoal);
    }

    private void ProgramCreateEternalGoal(string infoString)
    {
        string[] information = infoString.Split("|");
        EternalGoal eternalGoal = new EternalGoal(information[0], information[1], int.Parse(information[2]), this);
        _goalList.Add(eternalGoal);
    }

    private void ProgramCreateChecklistGoal(string infoString)
    {
        string[] information = infoString.Split("|");
        ChecklistGoal checklistGoal = new ChecklistGoal(information[0], information[1], int.Parse(information[2]), int.Parse(information[3]), 
                                                     int.Parse(information[4]), int.Parse(information[5]), this);
        _goalList.Add(checklistGoal);
    }
}