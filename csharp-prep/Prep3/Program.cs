using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,100);
        // Selects a random number between 1 and 100

        Console.WriteLine("The Magic Number has been chosen!");

        bool correctAnswer = false;
        while (correctAnswer != true)
        {
            string userInput = "";

            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            int playerGuess = int.Parse(userInput);
            // Obtains a guess input from the user

            if (magicNumber > playerGuess)
            {
                Console.WriteLine("Higher"); 
            } // Checks if the guess is lower than the Magic Number. If not, moves to the next check.

            else if (magicNumber < playerGuess)
            {
                Console.WriteLine("Lower");
            } // Checks if the guess is higher than the Magic Number. If not, both checks failed and the guess is correct.

            else
            {
                Console.WriteLine("You guessed it!");
                correctAnswer = true;
            } // Sets correctAnswer to true when the guess is correct. This ends the loop.
        }
    }
}