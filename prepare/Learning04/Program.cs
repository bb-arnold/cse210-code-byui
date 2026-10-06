using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Fred", "Milk");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Joe", "Multiplication", "Section 7.3", "Problems 8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Mary Gofredson", "History of History", "This is an amazing title");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}