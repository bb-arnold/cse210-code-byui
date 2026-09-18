using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //create variables
        int number = -1;
        List<int> numbers = new List<int>();
        double sum = 0; //I made sum a double so it will calculate the average correctly.
        int largestNumber = -999999999;
        double average = -99999999;
        int smallestPNumber = 999999999;
        int smallestNumber = 999999999;


        //Get numbers from user, append them to the list,
        //add them to the sum, and count how many there are.
        //Also keep track of the largest number
        while (number != 0)
        {
            Console.Write("Enter Number (To quit, enter 0): ");
            number = int.Parse(Console.ReadLine());



            if (number != 0)
            {
                numbers.Add(number);
                sum += number;                
            }

            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number < smallestPNumber && number > 0)
            {
                smallestPNumber = number;
            }

            

        }

        Console.WriteLine($"The sum is: {sum}");

        average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");

        Console.WriteLine($"The smallest positive number is: {smallestPNumber}");

        Console.WriteLine("The sorted list is:");


        while (numbers.Count != 0)
        {            

            //find the smallest number in the list
            foreach (int n in numbers)
            {
                if (n < smallestNumber)
                {
                    smallestNumber = n;
                }
            }

            //print it
            Console.WriteLine(smallestNumber);

            //remove it from the list
            numbers.Remove(smallestNumber);

            //reset smallest number
            smallestNumber = 999999999;
        }



        
    }
}