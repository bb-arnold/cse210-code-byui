using System;

class Entry
{
    //Variables
    public string _time = "";
    public string _prompt = "";
    public string _text = "";

    //This method displays the entry information to the screen
    public void EntryDisplay()
    {
        Console.WriteLine($"Date: {_time} - Prompt: {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine("");
    }
}