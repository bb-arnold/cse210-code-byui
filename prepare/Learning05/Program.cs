using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 4);
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());
    }
}