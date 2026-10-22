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

//Unwritten
    public bool IsEmpty()
    {
        return false;
    }

    public void SetPiece(ChessPiece newPiece)
    {
        _piece = newPiece;   
    }

    public string GetCoordinateString()
    {
        return _coordinate;
    }

    public ChessPiece GetPiece()
    {
        return _piece;
    }

//Unwritten
    public void SetEmpty()
    {
        
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