using System;

class BoardSquare
{
    string _choordinate;
    ChessPiece _piece;
    bool _empty;

//Unwritten
    public bool IsEmpty()
    {
        return false;
    }

    public void SetPiece(ChessPiece newPiece)
    {
        _piece = newPiece;   
    }

//Unwritten
    public string GetCoordinateString()
    {
        return "GetCoordinateString Unwritten";
    }

    public ChessPiece GetPiece()
    {
        return _piece;
    }

//Unwritten
    public void SetEmpty()
    {
        
    }

//Unwritten
    public string GetPieceDisplay()
    {
        return "GetPieceDisplay unwritten";
    }
}