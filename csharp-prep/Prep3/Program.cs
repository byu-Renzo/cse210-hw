using System;
using System.Net;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {

        string response;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;

            int guesses = 0;

            while (guess != magicNumber)
            {
                guesses++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guesses} guesses to find the magic number.");

            Console.Write("Do you want to continue? (yes if you do)");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}