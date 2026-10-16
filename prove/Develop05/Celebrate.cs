using System;

class Celebrate
{
    int _previous500Celebration;
    int _previous1000Celebration;
    public Celebrate(int celebrate500, int celebrate1000)
    {
        _previous1000Celebration = celebrate1000;
        _previous500Celebration = celebrate500;
    }

    public Celebrate()
    {
        _previous1000Celebration = 0;
        _previous500Celebration = 0;
    }
    

    public bool Celebrate500Check(int points)
    {
        int pointIncrease = points - _previous500Celebration;
        
        if (pointIncrease > 500)
        {
            //small celebration
            _previous500Celebration = points;

            return true;
        }

            return false;     
    }

    public bool Celebrate1000Check(int points)
    {
        int pointIncrease = points - _previous1000Celebration;
        
        if (pointIncrease > 1000)
        {
            //Large celebration
            _previous1000Celebration = points;

            return true;
        }

            return false;     
    }

    //method that returns the previous celebration constants that need stored as a combined string

    //method that sets the constants to the input strings

    //large celebration method
    public void LargeCelebration()
    {
        Console.WriteLine("CELEBRATE!!");
    }

    //small celebration method
    public void SmallCelebration()
    {
        Console.WriteLine("celebrate.");
    }
}