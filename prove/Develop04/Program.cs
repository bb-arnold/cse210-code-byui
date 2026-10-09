using System;
using System.Reflection;
using System.Runtime.CompilerServices;

/*
    For the creativity and exceeding requirements portion of this assignment, I added another activity called
the Imagining activity. This activity invites you to imagine a given (random from a list) senario
for however long you said you wanted to spend on the activity. It then invites you to write down how it
made you feel.
    I also combined the Run methods for each activity, but I didn't want the user in 
the main program to have to input the name of the hidden method that contains the unique code to run
each activity (for example BreathingActivity.BreatheInOut). I couldn't figure out how to store the
name of that method as a variable in the Activity class so it would know which method to call so I 
ended up using individual run methods for each function anyway. These methods, however, don't really
do anything, they simply call Activity.Run and pass in the correct method.
*/
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ImagningActivity imagningActivity = new ImagningActivity();

        int input = 0;

        while (input != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Start imagining activity");
            Console.WriteLine("   5. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    breathingActivity.RunBreathingActivity();
                }
                else if (input == 2)
                {
                    reflectingActivity.RunReflectingActivity();
                }
                else if (input == 3)
                {
                    listingActivity.RunListingActivity();
                }
                else if (input == 4)
                {
                    imagningActivity.RunImaginingActivity();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a number from 1-4.");
                Console.WriteLine();
            }
        }
    }
}