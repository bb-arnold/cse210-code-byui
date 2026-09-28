using System;

class Program
{
    static void Main(string[] args)
    {
        //create fraction
        Fraction fraction = new Fraction();

        //setter testing
        //fraction.SetBottom(4);
        //fraction.SetTop(4);

        //getter testing
        int bottom = fraction.GetBottom();
        int top = fraction.GetTop();

        //Display all ways to show the function.
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionString());

        
    }
}