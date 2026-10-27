using System;
using Spectre.Console;
using System.Text;
using System.ComponentModel;
using Spectre.Console.Rendering;

class Board
{
    private List<BoardSquare> _boardSquares = new List<BoardSquare>();

    public Board()
    {
        King whiteKing = new King("white");
        King blackKing = new King("black");

        Rook whiteRook = new Rook("white");
        Rook blackRook = new Rook("black");

        Bishop whiteBishop = new Bishop("white");
        Bishop blackBishop = new Bishop("black");

        Knight whiteKnight = new Knight("white");
        Knight blackKnight = new Knight("black");

        Pawn whitePawn = new Pawn("white");
        Pawn blackPawn = new Pawn("black");

        List<BoardSquare> _boardsquares1 = new List<BoardSquare>
        {
            new("A1", whiteRook),
            new("A2"),
            new("A3"),
            new("A4", blackPawn),
            new("A5", blackKing),

            new("B1", whiteBishop),
            new("B2"),
            new("B3"),
            new("B4"),
            new("B5", blackKnight),

            new("C1", whiteKnight),
            new("C2"),
            new("C3"),
            new("C4"),
            new("C5", blackBishop),

            new("D1", whiteKing),
            new("D2", whitePawn),
            new("D3"),
            new("D4"),
            new("D5", blackRook)
        };

        _boardSquares = _boardsquares1;
    }

    public void Display()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Table table = new Table()
            .ShowRowSeparators();

        table.AddColumn("   ");
        table.AddColumn(" A ");
        table.AddColumn(" B ");
        table.AddColumn(" C ");
        table.AddColumn(" D ");

        table.AddRow("5", FindSquare("A5").GetPieceDisplay(), FindSquare("B5").GetPieceDisplay(),FindSquare("C5").GetPieceDisplay(), FindSquare("D5").GetPieceDisplay());
        table.AddRow("4", FindSquare("A4").GetPieceDisplay(), FindSquare("B4").GetPieceDisplay(),FindSquare("C4").GetPieceDisplay(), FindSquare("D4").GetPieceDisplay());
        table.AddRow("3", FindSquare("A3").GetPieceDisplay(), FindSquare("B3").GetPieceDisplay(),FindSquare("C3").GetPieceDisplay(), FindSquare("D3").GetPieceDisplay());
        table.AddRow("2", FindSquare("A2").GetPieceDisplay(), FindSquare("B2").GetPieceDisplay(),FindSquare("C2").GetPieceDisplay(), FindSquare("D2").GetPieceDisplay());
        table.AddRow("1", FindSquare("A1").GetPieceDisplay(), FindSquare("B1").GetPieceDisplay(),FindSquare("C1").GetPieceDisplay(), FindSquare("D1").GetPieceDisplay());

        AnsiConsole.Write(table);
    }

    public void MovePiece(string coordinate1, string coordinate2)
    {
        BoardSquare startSquare = FindSquare(coordinate1);
        BoardSquare endSquare = FindSquare(coordinate2);

        endSquare.SetPiece(startSquare.GetPiece());
        startSquare.SetEmpty();
    }

    public bool IsMoveValid(string coordinate1, string coordinate2, string turnColor)
    {
        BoardSquare startSquare = FindSquare(coordinate1);
        BoardSquare endSquare = FindSquare(coordinate2);

        //print what error occured
        if (!OnBoard(coordinate1) || !OnBoard(coordinate2) || startSquare.GetCoordinateString() == "Z26"  || endSquare.GetCoordinateString() == "Z26")
        {
            Console.WriteLine("Entered coordinates must be on the board and in the format of a capital letter then a number.");
        }
        else if (startSquare.IsEmpty())
        {
            Console.WriteLine("The given start Square does not contain a piece.");
        }
        else if (turnColor != startSquare.GetPiece().GetColor())
        {
            Console.WriteLine("On your turn, only your pieces can move to other squares.");
        }
        else if (!endSquare.IsEmpty() && turnColor == endSquare.GetPiece().GetColor())
        {
            Console.WriteLine("The square you move to must not contain one of your pieces.");
        }
        else if (!startSquare.GetPiece().MoveValid(coordinate1, coordinate2))
        {
            Console.WriteLine("The given move is not valid for that type of piece.");
        }

        if (OnBoard(coordinate1) && OnBoard(coordinate2) &&
            //check if the space is empty
            !startSquare.IsEmpty() && 
            //check if the moving piece is the right color
            turnColor == startSquare.GetPiece().GetColor() &&
            //check if the space being moved to is empty or contains the correct piece color
            (endSquare.IsEmpty() || turnColor != endSquare.GetPiece().GetColor()) &&
            //check if the move is valid for that given piece
            startSquare.GetPiece().MoveValid(coordinate1, coordinate2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private BoardSquare FindSquare(string coordinate)
    {
        BoardSquare returnSquare = new BoardSquare("Z26");

        foreach (BoardSquare square in _boardSquares)
        {
            if (coordinate == square.GetCoordinateString())
            {
                returnSquare = square;
            }
        }
        return returnSquare;
    }

    private bool OnBoard(string coordinate)
    {
        bool criteria1 = false;
        bool criteria2 = false;

        if (coordinate.Length != 2)
        {
            return false;
        }
        else
        {
            foreach (Char character in coordinate)
            {
                if (character == 'A' || character == 'B' || character == 'C' || character == 'D')
                {
                    criteria1 = true;
                }

                if (character == '1' || character == '2' || character == '3' || character == '4' || character == '5')
                {
                    criteria2 = true;
                }                
            }

            if (criteria1 && criteria2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public bool VictoryAchieved(string turnColor)
    {
        bool returnBool = true;

        foreach(BoardSquare square in _boardSquares)
        {
            if (!square.IsEmpty())
            {
                if (square.GetPiece().GetColor() != turnColor && square.GetPiece() is King)
                {
                    returnBool = false;
                }
            }
        }

        return returnBool;
    }
}