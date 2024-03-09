using System;

namespace EnhancedGuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Guessing Game!");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option (1-2): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        PlayGame();
                        break;
                    case "2":
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void PlayGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int guess = 0;
            int numberOfGuesses = 0;
            int guessLimit = 5;
            Console.WriteLine("\nGuess the number between 1 and 100. You have 5 attempts.");

            while (guess != randomNumber && numberOfGuesses < guessLimit)
            {
                Console.Write("Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                numberOfGuesses++;

                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high, try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the right number in {numberOfGuesses} guesses.");
                    break;
                }
            }

            if (guess != randomNumber)
            {
                Console.WriteLine($"Sorry, you've reached your guess limit. The correct number was {randomNumber}.");
            }

            Console.Write("Press any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}
