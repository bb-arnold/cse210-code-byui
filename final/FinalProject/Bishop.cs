using System;

class Bishop : ChessPiece
{
    public Bishop(string color)
    : base(color)
    {
        _displayStringBlack = "♗";
        _displayStringWhite = "♝";
    }

    public override bool MoveValid(string coordinate1, string coordinate2)
    {
        int verticalDistance = Math.Abs(EffectiveCoordinateDistance("vertical", coordinate1, coordinate2));
        int horizontalDistance = Math.Abs(EffectiveCoordinateDistance("horizontal", coordinate1, coordinate2));

        if(verticalDistance == horizontalDistance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}