using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        Celebrate celebrate = new Celebrate();
        int input = 0;

        while (input != 6)
        {
            if (!celebrate.Celebrate1000Check(user.GetPoints()))
            {
                celebrate.Celebrate500Check(user.GetPoints());
            }
            
            user.PrintPoints();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    user.UserCreateGoal();
                }
                else if (input == 2)
                {
                    user.DisplayGoals();
                }
                else if (input == 3)
                {
                    user.SaveGoals(celebrate);
                }
                else if (input == 4)
                {
                    user.LoadGoals(celebrate);
                }
                else if (input == 5)
                {
                    user.RecordEvent();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter an integer 1 - 6");
                Console.WriteLine();
            }
        }
    }
}