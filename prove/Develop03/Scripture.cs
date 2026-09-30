using System;

class Scripture
{
    public Scripture(string wordsString, string book, int chapter, int verseStart, int verseEnd)
    {
        Reference reference = new Reference(book, chapter, verseStart, verseEnd);


    }
}