using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine(number);
        
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guessNumber = int.Parse(guessInput);

        int countGuess = 1;
        

        while (guessNumber != number)
        {
            if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guessInput = Console.ReadLine();
            guessNumber = int.Parse(guessInput);
            countGuess += 1;
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It too you {countGuess} tries!");
    }
}