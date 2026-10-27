using System;
using System.Drawing;

class Pawn : ChessPiece
{
    public Pawn(string color)
    : base(color)
    {
        _displayStringBlack = "♙";
        _displayStringWhite = "♟";
    }

    public override bool MoveValid(string coordinate1, string coordinate2)
    {
        int verticalDistance = EffectiveCoordinateDistance("vertical", coordinate1, coordinate2);
        int horizontalDistance = Math.Abs(EffectiveCoordinateDistance("horizontal", coordinate1, coordinate2));

        if (GetColor() == "black")
        {
            if (verticalDistance == 1 && horizontalDistance <= 1)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (verticalDistance == -1 && horizontalDistance <= 1)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}