using System;

class Queen : ChessPiece
{
    public Queen(string color)
    : base(color)
    {
        _displayStringBlack = "♕";
        _displayStringWhite = "♛";
    }

    //Unwritten
    public override bool MoveValid(string coordinate1, string coordinate2)
    {
        return true;
    }
}