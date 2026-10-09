using System;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        int input = 0;

        while (input != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
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
                else if (input ==3)
                {
                    listingActivity.RunListingActivity();
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