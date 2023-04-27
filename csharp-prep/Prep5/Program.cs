using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        } // Displays welcome message.

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userInput = Console.ReadLine();
            return userInput;
        } // Asks for and returns the user's name.

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            return number;
        } // Asks for and returns the user's number.

        static void DisplayResult()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int numberSquared = userNumber * userNumber;
            Console.Write($"{userName}, the square of your number is {numberSquared}");
        } // Calls above functions and puts all the inputs together.

        DisplayResult();
        // Calls the DisplayResult function, which calls all the other functions in order to get the intended result.
    }
}