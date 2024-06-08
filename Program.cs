using System;

class GuessingGame
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");
        int guess;

        do
        {
            guess = int.Parse(Console.ReadLine());

            if (guess > targetNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        } while (guess != targetNumber);
    }
}