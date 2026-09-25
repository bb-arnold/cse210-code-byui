using System;

class Journal
{
    //base variables
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(string text, string prompt, string time, List<string> prompts)
    {
        //Create entry
        Entry entry = new Entry();

        //assign variables
        entry._time = time;
        entry._prompt = prompt;
        entry._text = text;

        //Add entry to list
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        
    }

    public void SaveEntries()
    {
        
    }

    public void LoadEntries()
    {
        
    }
}