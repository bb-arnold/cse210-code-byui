using System;

class Scripture
{
    public List<Word> _words = new List<Word>();

    public Scripture(string wordsString, string book, int chapter, int verseStart, int verseEnd)
    {
        Reference _reference = new Reference(book, chapter, verseStart, verseEnd);

        AddWords(wordsString);
    }

    public Scripture(string wordsString, string book, int chapter, int verseStart)
    {
        Reference _reference = new Reference(book, chapter, verseStart);

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

            _words.Add(word);
        }
    }
}