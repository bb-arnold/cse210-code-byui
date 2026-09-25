using System;

class Program
{
    static void Main(string[] args)
    {
        Entry testEntry = new Entry();

        testEntry._prompt = "This is a test prompt";
        testEntry._text = "This is the test text";
        testEntry._time = "Date/Test/is";

        testEntry.EntryDisplay();

        Console.WriteLine("Hello Develop02 World!");
    }
}