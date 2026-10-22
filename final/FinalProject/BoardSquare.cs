using System;

class BoardSquare
{
    string _coordinate;
    ChessPiece _piece;
    bool _empty;

    public BoardSquare(string coordinate)
    {
        _coordinate = coordinate;
        _empty = false;
    }

    public BoardSquare(string coordinate, ChessPiece piece)
    {
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