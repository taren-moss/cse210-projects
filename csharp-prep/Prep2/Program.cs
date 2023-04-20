using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage? ");
        string userInput = Console.ReadLine();
        int numberInput = int.Parse(userInput);

        if (numberInput >= 90)
        {
            Console.WriteLine("Your Letter Grade is 'A'.");
        }
        else if (numberInput >= 80)
        {
            Console.WriteLine("Your Letter Grade is 'B'.");
        }
        else if (numberInput >= 70)
        {
            Console.WriteLine("Your Letter Grade is 'C'.");
        }
        else if (numberInput >= 60)
        {
            Console.WriteLine("Your Letter Grade is 'D'.");
        }
        else
        {
            Console.WriteLine("Your Letter Grade if 'F'.");
        }

        if (numberInput >= 70)
        {
            Console.Write("Congratulations! You passed the class!");
        }
        else
        {
            Console.Write("You failed the class.. don't worry, you'll do better next time!");
        }
    }
}