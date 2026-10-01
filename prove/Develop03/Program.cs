using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("And my father dwelt in a tent", "1 Nephi", 2, 15);
        string input = " ";
        bool finished = false;

        while (input != "quit" && !finished)
        {
            Console.Clear();

            //print scripturestring
            Console.WriteLine(scripture.ScriptureString());
            Console.WriteLine();
            //print message asking for input
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            //read input into input variable
            input = Console.ReadLine();

            //check if scripture is hidden. if so, finished = true. else HideWords
            if (scripture.IsHidden())
            {
                finished = true;
            }
            else
            {
                scripture.HideWords();
            }
        }      
    }
}