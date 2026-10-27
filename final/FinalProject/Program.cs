using System;
using Spectre.Console;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        bool gameEnd = false;

        string startCoordinate;
        string endCoordinate;
        string turnColor = "white";

        while (!gameEnd)
        {
            board.Display();

            Console.WriteLine($"It is {turnColor}'s turn.");
            Console.WriteLine("What is the current coordinate of the piece would you like to move? (input quit at any time to end the game)");

            Console.Write("Move: ");
            startCoordinate = Console.ReadLine();

            Console.Write("To: ");
            endCoordinate = Console.ReadLine();

            Console.WriteLine();

            if (startCoordinate == "quit" || endCoordinate == "quit")
            {
                break;
            }
            
            if (board.IsMoveValid(startCoordinate, endCoordinate, turnColor))
            {
                board.MovePiece(startCoordinate, endCoordinate);

                if (board.VictoryAchieved(turnColor))
                {
                    gameEnd = true;
                }
                else
                {
                    if (turnColor == "white")
                    {
                        turnColor = "black";
                    }
                    else
                    {
                        turnColor = "white";
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid move.");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine($"congradulations {turnColor}");
    }
}