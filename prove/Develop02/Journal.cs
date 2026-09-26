using System;
using System.IO;

class Journal
{
    //base variables
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(string text, string prompt, string time)
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
    {   try
        {
            //open file
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    //Add entry information in the format
                    //time,prompt,text. 
                    outputFile.WriteLine($"{entry._time},{entry._prompt},{entry._text}");

                }
            }
            Console.WriteLine("Save Success");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("Save failed. Please enter a valid filename");
        }
    }

    public void LoadEntries(string fileName, Journal journal)
    {

        try
        {
            //read all lines, save them to an array of strings
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                //separate the line parts
                string[] parts = line.Split(",");
                //create new entry
                journal.AddEntry(parts[2], parts[1], parts[0]);

                
            }
            Console.WriteLine("Load Success.");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("Load failed. Please enter a valid filename");
        }
    }
}