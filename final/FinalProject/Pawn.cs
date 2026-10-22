using System;

class Pawn : ChessPiece
{
    public Pawn(string color)
    : base(color)
    {
        _displayStringBlack = "♙";
        _displayStringWhite = "♟";
    }

    //Unwritten
    public override bool MoveValid(string coordinate1, string coordinate2, string turnColor)
    {
        return false;
    }
}