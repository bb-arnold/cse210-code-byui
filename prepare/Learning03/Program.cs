using System;

class Program
{
    static void Main(string[] args)
    {
        //create variables
        Fraction fraction = new Fraction();
        int i = 1;

        //loop
        while (i < 21)
        {
            Console.WriteLine($"Fraction {i}: {fraction.RandomFractionString()}");
            i += 1;
        }
    }
}