using System;
using System.Runtime.CompilerServices;

class Scripture
{
    private List<Word> _verse = new List<Word>();
    private Reference _reference = new Reference();

    public Scripture(string wordsString, string book, int chapter, int verseStart, int verseEnd)
    {
        _reference.AddInfo2(book, chapter, verseStart, verseEnd);

        AddWords(wordsString);
    }

    public Scripture(string wordsString, string book, int chapter, int verseStart)
    {
        _reference.AddInfo1(book, chapter, verseStart);

        AddWords(wordsString);
    }

    private void AddWords(string wordsString)
    {
        //split up the string by spaces
        string[] wordsArray = wordsString.Split();

        //iterate through each word in the string, create a new word 
        //object for each one and add that to the list.
        foreach (string loopWord in wordsArray)
        {
            Word word = new Word(loopWord); 

            _verse.Add(word);
        }
    }

    public string ScriptureString()
    {
        string scriptureString = $"{_reference.GetReference()}";

        foreach (Word word in _verse)
        {
            //A space is needed before each word.
            scriptureString += $" {word.GetWord()}";
        }
        
        return scriptureString;
    }
}