using System;

class Program
{
    static void Main(string[] args)
    {
        //Base variables
        int input = 0;
        int input2 = 0;
        string prompt = " ";
        string time = " ";
        string text = " ";

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        List<string> prompts = ["What was the best thing I ate today?" ,
                                "What was the best part of my day?" ,
                                "Who was the most interesting person I met today?" ,
                                "What is one thing I did today that I am proud of?" ,
                                "What is one way I saw God's hand in my life today?"];


        //Initial message
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal program");

        while (input != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            try
            {
                //read input
                input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Write option
                if (input == 1)
                {
                    //ask 1 gen ran prompt, 2 insert custom prompt
                    //read this
                    Console.WriteLine("Please Select one of the following choices:");
                    Console.WriteLine("1. Generate a random prompt to answer");
                    Console.WriteLine("2. Type in your own prompt");

                    try
                    {
                        input2 = int.Parse(Console.ReadLine());

                        if(input2 == 1)
                        {
                            //set and print prompt
                            prompt = promptGenerator.GeneratePrompt(prompts);
                            Console.WriteLine(prompt);
                        }
                        else if(input2 == 2)
                        {
                            Console.WriteLine("Please enter your prompt.");
                            prompt = Console.ReadLine();
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("1 and 2 are the only valid inputs for this prompt.");
                    }

                    //allow input, set that to the text variable
                    Console.Write(">");
                    text = Console.ReadLine();

                    //get date from system, set time to that
                    time = DateTime.Now.ToShortDateString();

                    //call AddEntry passing in those variables
                    journal.AddEntry(text, prompt, time);
                }

                //Display option
                else if (input == 2)
                {
                    journal.DisplayEntries();
                }

                //Load option
                else if (input == 3)
                {
                    //Ask for filename
                    Console.WriteLine("What is the filename?");
                    string fileName = Console.ReadLine();

                    journal.LoadEntries(fileName, journal);
                }

                //Save option
                else if (input == 4)
                {
                    //Ask for filename
                    Console.WriteLine("What is the filename?");
                    string fileName = Console.ReadLine();

                    journal.SaveEntries(fileName);
                }
                
                else if (input == 5)
                {  
                }
                
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 5 inclusive.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine("Please input a number between 1 and 5 inclusive.");
                Console.WriteLine("");
            } 
            catch (ArgumentNullException)
            {
                Console.WriteLine("");
                Console.WriteLine("Input is null. Please input a number between 1 and 5 inclusive.");
                Console.WriteLine("");                
            }
        }
    }
}