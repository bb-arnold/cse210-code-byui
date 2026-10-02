using System;

/*
For the added creativity portion of this assignment, I added an option to reset the verse you are trying to guess so you can start over without having to restart the
program. I also added a congratulatory/informative message that prints when the program finishes.
*/
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("And it came to pass that I Nephi said unto my Father, 'I will go and do the things which the Lord hath commanded. For I know that the Lord giveth no commandments unto the children of men save He shall prepare a way for them that they may accomplish the thing which he commandeth them.'", "1 Nephi", 3, 7);
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

            //check if input = reset. if so, reset - restart the loop. Else if check if scripture scripture is hidden. if so, 
            // finished = true. else HideWords
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
        Console.Clear();
        scripture.ShowWords();
        Console.Clear();
        Console.WriteLine("Great job working to memorize scriptures!");

        Console.WriteLine();
        Console.WriteLine("Today you were working to memorize:");
        Console.WriteLine(scripture.ScriptureString());

        Console.WriteLine();
    }
}