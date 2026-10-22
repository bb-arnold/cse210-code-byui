using System;
using System.Xml;

abstract class ChessPiece
{
    string _color;
    string _displayStringWhite;
    string _displayStringBlack;

//Unwritten
    public abstract bool MoveValid(string coordinate1, string coordinate2, string turnColor);

    public string GetDisplayString()
    {
        if (_color == "white")
        {
            return _displayStringWhite;
        }
        else
        {
            return _displayStringBlack;
        }
    }
}