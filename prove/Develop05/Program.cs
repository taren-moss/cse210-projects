using System;

class Program
{
    static void Main(string[] args) // The code for the main program is a lot denser than the code everywhere else.
    {
        bool loop = true;
        File mainFile = new File();

        while (loop)
        {   // Just menu stuff
            Console.WriteLine();
            Console.WriteLine($"You have {mainFile.GetPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            int userInput = int.Parse(Console.ReadLine());
            
            if (userInput == 1) // User Input 1 has a lot of steps
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");

                int goalType = int.Parse(Console.ReadLine());

                if (goalType == 1) // Goal Type 1 is simple goal
                {  
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Write a short description of your goal: ");
                    string description = Console.ReadLine();

                    Console.Write("How many points is this goal worth? ");
                    int pointValue = int.Parse(Console.ReadLine());

                    mainFile.SaveGoal(new SimpleGoal(name, description, pointValue)); // Constructors work nice
                }
                else if (goalType == 2) // Goal Type 2 is eternal goal
                {
                    Console.Write("What is the name of your goal? "); // Same questions as simple goal
                    string name = Console.ReadLine();

                    Console.Write("Write a short description of your goal: ");
                    string description = Console.ReadLine();

                    Console.Write("How many points is this goal worth? ");
                    int pointValue = int.Parse(Console.ReadLine());

                    mainFile.SaveGoal(new EternalGoal(name, description, pointValue)); // Eternal Goal Constructor
                }
                else if (goalType == 3) // Goal Type 3 is checklist goal
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Write a short description of your goal: ");
                    string description = Console.ReadLine();

                    Console.Write("How many points is this goal worth? ");
                    int pointValue = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be accomplished? "); // New questions
                    int count = int.Parse(Console.ReadLine());

                    Console.Write($"How many bonus points do you get from {count} completions? "); // uses above answer in question
                    int bonus = int.Parse(Console.ReadLine());

                    mainFile.SaveGoal(new ChecklistGoal(name, description, pointValue, 0, count, bonus)); // Big checklist constructor
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Input"); // Error stuff
                }
            }
            else if (userInput == 2) // List Goals
            {
                Console.WriteLine();
                Console.WriteLine("Your goals are:");
                mainFile.PrintFile(); // Print file printing all the goals in order
                Console.WriteLine();
            }
            else if (userInput == 3) // Save File
            {
                Console.Write("Save as: ");
                string filename = Console.ReadLine();

                mainFile.SaveFile(filename); // The magic happens here. Abstraction at play.
            }
            else if (userInput == 4) // Load File
            {
                Console.Write("Load from: ");
                string filename = Console.ReadLine();

                mainFile.LoadFile(filename); // Does the save file thing, but backwards
            }
            else if (userInput == 5) // Record Event
            {
                mainFile.ListGoals(); // List goal data
                Console.Write("Which goal did you accomplish? ");

                int input = int.Parse(Console.ReadLine());

                int pointGain = mainFile.RecordGoal(input - 1); // Accepts input as index. Index used to record goal function.
                Console.WriteLine($"Congratulations! You have earned {pointGain} points!");
                Console.WriteLine($"You now have {mainFile.GetPoints()} points.");
                Console.WriteLine();
            }
            else if (userInput == 6) // Quit
            {
                Console.WriteLine("[Closing Program...]");
                Thread.Sleep(500); // Pause for dramatic effect
                Console.WriteLine("[Program Closed]");
                loop = false; // All you need to do to end the loop is set loop to false
            }
        }
    }
}