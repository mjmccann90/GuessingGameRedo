using System;

namespace GuessingGamePtTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessesAllowed;
            int guessesGiven = 0;
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);

            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("Easy (8 attempts)");
            Console.WriteLine("Medium (6 attempts)");
            Console.WriteLine("Hard (4 attempts)");
            string selectedDifficulty = Console.ReadLine();

            switch (selectedDifficulty)
            {
                case ("Easy"):
                    guessesAllowed = 8;
                    break;

                case ("Hard"):
                    guessesAllowed = 4;
                    break;

                case ("Medium"):
                    guessesAllowed = 6;
                    break;
            }
            bool canKeepGuessing = true;

            while (canKeepGuessing || selectedDifficulty == "Cheaters never prosper")

            {
                Console.WriteLine($"Guess the secret number!!!");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yep Yep, your guessed it!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("WRONG!");

                    if (userGuessInt > secretNumber)
                    {
                        Console.WriteLine($"Way too high! You have {guessesAllowed - guessesGiven - 1} more attempt(s)");
                    }
                    else
                    {
                        Console.WriteLine($"Way too low! You have {guessesAllowed - guessesGiven - 1} more attempt(s)");
                    }
                }
                guessesGiven++;
                canKeepGuessing = guessesGiven < guessesAllowed;
            }
        }
    }
}