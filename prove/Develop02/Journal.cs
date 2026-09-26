using System;
using System.IO;

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
        foreach (Entry entry in _entries)
        {
            entry.EntryDisplay();
        }
    }

    public void SaveEntries(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {

                outputFile.WriteLine(entry._time);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._text);
            }
        }
    }

    public void LoadEntries()
    {
        
    }
}