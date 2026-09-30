using System;

class Program
{
    static void Main(string[] args)
    {
        //create word
        Word word = new Word("test word");

        //test word.IsHidden()
        if (!word.IsHidden())
        {
            Console.WriteLine("the word is not hidden");
        }
        else
        {
            Console.WriteLine("the word is hidden");
        }

        //test word.GetWord()
        Console.WriteLine(word.GetWord());

        //test word.HideWord()
        word.HideWord();

        //print _wordDisplay - it should now be all underscores
        Console.WriteLine(word.GetWord());

        //double check word.IsHidden
        if (!word.IsHidden())
        {
            Console.WriteLine("the word is not hidden");
        }
        else
        {
            Console.WriteLine("the word is hidden");
        }

    }
}