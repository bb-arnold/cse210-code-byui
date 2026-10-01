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
            Console.WriteLine("Press enter to continue, type 'quit' to finish, or type 'reset' to restart:");

            //read input into input variable
            input = Console.ReadLine();

            //check if input = reset. if so, reset - restart the loop. Else if check if scripture scripture is hidden. if so, finished = true. else HideWords
            if (input == "reset")
            {
                scripture.ShowWords();
            }
            else if (scripture.IsHidden())
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