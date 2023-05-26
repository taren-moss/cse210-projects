using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        string userInput = "";
        Scripture jacob = new Scripture();

        while (loop) // I like to use a boolean variable called loop for my basic loops
        {
            jacob.PrintText();
            Console.WriteLine();

            if (jacob.HiddenStatus() == true) // If all words are hidden, end the program.
            {
                loop = false;
                Console.WriteLine("[Program Ended]");
            }

            userInput = Console.ReadLine(); // You can put anything in here, really. Only "quit" does something.
            jacob.HideWords();

            if (userInput.ToLower() == "quit") // If the user types "quit", end the program. Not case sensitive.
            {
                loop = false;
                Console.WriteLine("[Program Ended]");
            }
        }

    }
}