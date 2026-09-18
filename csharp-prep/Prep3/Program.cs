using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        //Create variables
         int gNumber = -1;
         int rNumber = randomGenerator.Next(1,101);
         int i = 0;
         string playAgain = "";

        do
        {
            //Ask for your guess and change it into an int.
            //Saved as gNumber.
            Console.Write("What is your guess? ");
            string gNumberString = Console.ReadLine();
            gNumber = int.Parse(gNumberString);

            //Keep track of the number of guesses
            i++;

            //Check values against each other, print appropriate
            //messages.
            if (gNumber < rNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (gNumber > rNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {i} guess(es)");

                //See if you want to play again
                Console.Write("Would you like to play again? (yes or no) ");
                playAgain = Console.ReadLine();

                //Reset for next game
                i = 0;
                rNumber = randomGenerator.Next(1,101);

            }


        } while (playAgain != "no");

    }
}