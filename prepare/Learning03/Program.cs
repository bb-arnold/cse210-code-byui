using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(5,7);
        fraction.SetBottom(4);
        fraction.SetTop(4);
        
        int bottom = fraction.GetBottom();
        int top = fraction.GetTop();
        Console.WriteLine($"{top}/{bottom}");
    }
}