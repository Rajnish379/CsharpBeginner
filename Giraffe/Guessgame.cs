using System;

namespace PartialClasses
{
    public partial class PartialClass
    {
        public void Guessgame()
        {

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter the guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;

                }


            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }

            Console.ReadLine();

        }
    }
}