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

        Activity testActivity = new Activity();
        testActivity.CountdownSpinner("This is the test spinner extra test text", 1, "same");

        testActivity.CountdownNumbers("This is the test number countdown test", 4, "new");
    }
}