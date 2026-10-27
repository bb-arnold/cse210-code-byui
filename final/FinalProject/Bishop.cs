using System;

class Bishop : ChessPiece
{
    public Bishop(string color)
    : base(color)
    {
        _displayStringBlack = "♗";
        _displayStringWhite = "♝";
    }

    //Unwritten
    public override bool MoveValid(string coordinate1, string coordinate2)
    {
        int verticalDistance = EffectiveCoordinateDistance("vertical", coordinate1, coordinate2);
        int horizontalDistance = EffectiveCoordinateDistance("horizontal", coordinate1, coordinate2);

        if(verticalDistance == horizontalDistance)
        {
            Console.WriteLine("it returned true");
            return true;
        }
        else
        {
            Console.WriteLine("it returned false");
            return false;
        }
    }
}