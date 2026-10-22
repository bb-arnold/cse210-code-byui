using System;
using Spectre.Console;
using System.Text;
using System.ComponentModel;

class Board
{
    List<BoardSquare> _boardSquares1 = new List<BoardSquare>();

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

        List<BoardSquare> _boardsquares = new List<BoardSquare>
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
    }

    public void Display()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Table table = new Table()
            .ShowRowSeparators();

        table.AddColumn("   ");
        table.AddColumn(" 1 ");
        table.AddColumn(" 2 ");
        table.AddColumn(" 3 ");
        table.AddColumn(" 4 ");

        table.AddRow("D", "", "♘");
        table.AddRow("♜", "♚", "♞");
        table.AddRow("♟", "♛", "♙");

        table.Border(TableBorder.HeavyHead);

        AnsiConsole.Write(table);
    }

//Unwritten
    public void MovePiece(string coordinate1, string coordinate2)
    {

    }

//Unwritten
    public bool IsMoveValid(string coordinate1, string coordinate2, string turnColor)
    {
        return true;
    }

//Unwritten
    private string FindSquare(string coordinate)
    {
        return "FindSquare Unwritten";
    }

//Unwritten
    public bool VictoryCheck()
    {
        return false;
    }
}