using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Spectre.Console;

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

    public override bool PawnAdditionalMoveValid(BoardSquare startSquare, string coordinate1, BoardSquare endSquare, string coordinate2)
    {
        //Pawn Special Case when the move is not valid (Pawns can't take a piece that is directly in front of them)
        //then Pawn special case - they can't move diagonally unless there is a piece there
        //then the else which returns true.

            //the piece we are moving (this piece) is not moving horizonatally at all and
        if (EffectiveCoordinateDistance("horizontal", coordinate1, coordinate2) == 0 &&
            //the space we are moving to is not empty
            !endSquare.IsEmpty())
        {
            Console.WriteLine("The given move is not valid for a Pawn.");
            return false;
        }
        else if (Math.Abs(EffectiveCoordinateDistance("horizontal", coordinate1, coordinate2)) == 1 &&
                 Math.Abs(EffectiveCoordinateDistance("vertical", coordinate1, coordinate2)) == 1 &&
                 endSquare.IsEmpty())
        {
            Console.WriteLine("The given move is not valid for a Pawn.");
            return false;
        }
        else
        {
            return true;
        }
    }
}