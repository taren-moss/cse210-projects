using System;

class Program
{
    static void Main(string[] args)
    {
        static void Menu() // I tried to follow the revised diagram but this function worked much better here.
        {
            bool loop = true;

            Journal newJournal = new Journal();

            while (loop == true)
            {
                Entry newEntry = new Entry(); // Every loop creates a new Entry and displays the menu
                Console.WriteLine("Select one of the options below:");
                Console.WriteLine("1. Write Entry");
                Console.WriteLine("2. Display Current File");
                Console.WriteLine("3. Load File");
                Console.WriteLine("4. Save File");
                Console.WriteLine("5. Quit Program");
                Console.Write("What would you like to do? ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1") // Inputs are recorded by Entry.cs, and then used as an argument in AddEntry()
                {
                    newEntry.RecordInput();
                    newJournal.AddEntry(newEntry);
                    Console.WriteLine("");
                }
                else if (input == "2") // Displaying the entries was forgotten on the revised plan. I had Journal.cs handle it.
                {
                    newJournal.DisplayEntries();
                }
                else if (input == "3") // Load is handled by Journal.cs
                {
                    newJournal.Load();
                    Console.WriteLine("");
                }
                else if (input == "4") // Save is handled by Journal.cs
                {
                    newJournal.Save();
                    Console.WriteLine("");
                }
                else if (input == "5") // Simply end the loop to end the program
                {
                    loop = false;
                    Console.WriteLine("[Program Closed]");
                }
                else // It catches stuff so it doesn't crash at small typos or letters
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("");
                }
            }
        }

        Menu();
    }
}