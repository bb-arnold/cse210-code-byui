using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageString = Console.ReadLine();

        int gradePercentage = int.Parse(gradePercentageString);

        string letter = "";
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";    
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";    
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";    
        }
        else
        {
            letter = "F";    
        }

        if ((gradePercentage % 10) >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if ((gradePercentage % 10) < 3 && letter != "F")
        {
            sign = "-";
        }

        Console.WriteLine($" Your grade is {letter + sign}");


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congradulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass. Keep trying!");
        }
 
    }
}