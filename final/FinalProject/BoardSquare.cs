using System;

class BoardSquare
{
    string _coordinate;
    ChessPiece _piece;
    bool _empty;

    public BoardSquare(string coordinate)
    {
        _coordinate = coordinate;
        _empty = true;
    }

    public BoardSquare(string coordinate, ChessPiece piece)
    {
        _coordinate = coordinate;

        _piece = piece;
        _empty = false;
    }

    public bool IsEmpty()
    {
        return _empty;
    }

    public void SetPiece(ChessPiece newPiece)
    {
        _piece = newPiece; 
        _empty = false;  
    }

    public string GetCoordinateString()
    {
        return _coordinate;
    }

    public ChessPiece GetPiece()
    {
        return _piece;
    }

    public void SetEmpty()
    {
        _empty = true;
    }

    public string GetPieceDisplay()
    {
        if (!_empty)
        {
            return _piece.GetDisplayString();
        }
        else
        {
            return " ";
        }
    }
}