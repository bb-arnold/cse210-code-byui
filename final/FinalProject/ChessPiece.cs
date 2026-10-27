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

    /// <summary>
/// This method finds the distance in squares between 2 rows or 2 columns.
/// </summary>
/// <param name="direction">horizontal or vertical</param>
/// <param name="coordinate1"></param>
/// <param name="coordinate2"></param>
/// <returns>The distance between the 2 rows/columns</returns>
    public int EffectiveCoordinateDistance(string direction, string coordinate1, string coordinate2)
    {
        int compare1 = 0;
        int compare2 = 0;
        int i = 1;

        List<char> lettersToCheck = ['A', 'B', 'C', 'D'];
        List<char> numberRange = ['1', '2', '3', '4', '5'];

        //set compare1 and compare2
        if (direction == "horizontal")
        {
            foreach (char letter in lettersToCheck)
            {
                if (coordinate1[0] == letter)
                {
                    compare1 = i;
                }
                if (coordinate2[0] == letter)
                {
                    compare2 = i;
                }
                i++;
            }
        }
        else if (direction == "vertical")
        {
            foreach (int number in numberRange)
            {
                if (coordinate1[1] == number)
                {
                    compare1 = i;
                }
                if (coordinate2[1] == number)
                {
                    compare2 = i;
                }
                i++;
            }
        }

        int result1 = compare1 - compare2;
        //result1 = Math.Abs(result1); removing this for the pawn class
        return result1; 
    }
}