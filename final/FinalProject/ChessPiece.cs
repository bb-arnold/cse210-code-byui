using System;
using System.Xml;

abstract class ChessPiece
{
    private string _color;
    protected string _displayStringWhite;
    protected string _displayStringBlack;

    public ChessPiece(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

//Unwritten
    public abstract bool MoveValid(string coordinate1, string coordinate2);

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