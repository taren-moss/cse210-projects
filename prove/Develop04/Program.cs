using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string playerChoice = Console.ReadLine();
            Console.Clear();
            if (playerChoice == "1")
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.RunBreathing();
            }
            else if (playerChoice == "2")
            {
                ReflectionActivity activity2 = new ReflectionActivity();
                activity2.RunReflection();
            }
            else if (playerChoice == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.RunListing();
            }
            else if (playerChoice == "4")
            {
                Console.Write("CLOSING PROGRAM");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.Write(".");
                Thread.Sleep(250);
                Console.WriteLine();
                loop = false;
                Console.WriteLine("[PROGRAM ENDED]");
            }
            else
            {
                Console.Clear();
                Thread.Sleep(1000);
            }
        }
    }
}