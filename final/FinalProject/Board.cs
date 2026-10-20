using System;
using Spectre.Console;
using System.Text;

class Board
{
    public void TableTesting()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Table table = new Table();

        table.AddColumn(" ♕ ");
        table.AddColumn(" ♖ ");
        table.AddColumn(" ♗ ");

        table.AddRow("♝", "♔", "♘");
        table.AddRow("♜", "♚", "♞");
        table.AddRow("♟", "♛", "♙");

        table.Border(TableBorder.HeavyHead);
        

        AnsiConsole.Write(table);
    }
}