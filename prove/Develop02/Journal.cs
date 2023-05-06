using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) // Using an argument like this seemed like the easiest way to handle this.
    {
        _entries.Add(newEntry);
    }

    public void Load()
    {
        // This method was a pain to write and get working. The Save() method saves 4 lines for each item in the entry list.
        // To put it as simply as possible this method just reads the lines from top to bottom 4 at a time and puts the data
        // in the place it belongs based on the format. It creates a new item in the list for every 4 lines it finds, and then
        // loads the final list into the Journal's list.
        Console.Write("Load from: ");
        string fileName = Console.ReadLine();
        int lineCount = 0;
        int loadCount = 0;

        List<Entry> loadedEntries = new List<Entry>();
        loadedEntries.Add(new Entry()); // Apparently you can't just load an item in an if statement, so I added 1 item to start with

        string[] loadData = System.IO.File.ReadAllLines(fileName);
        foreach (string line in loadData)
        {
            if (lineCount == 0)
            {
                loadedEntries[loadCount]._getDate = line;
            }
            else if (lineCount == 1)
            {
                loadedEntries[loadCount]._sortedPrompt = line;
            }
            else if (lineCount == 2)
            {
                loadedEntries[loadCount]._saveInput = line;
            }
            else if (lineCount == 3)
            {
                loadedEntries.Add(new Entry()); // This line adds another blank entry to the list, which is necessary, but adds +1 at the end.
                lineCount = -1; // Each journal is 4 lines. This sets line count to -1 so that it starts at 0 again after "lineCount +=1;"
                loadCount += 1;
            }
            lineCount += 1;
        }
        Console.WriteLine(loadedEntries[0]._getDate);
        _entries = loadedEntries;

        // Got help from https://stackoverflow.com/questions/23245569/how-to-remove-the-last-element-added-into-the-list
        _entries.RemoveAt(_entries.Count() - 1); // This line removes the extra blank entry from the end.
        Console.WriteLine($"Loaded {loadCount} Entries"); // Fancy message to look nice
    }

    public void Save()
    {
        // This function saves the file by putting out 4 rows for each entry (one line for each piece of data + a blank one for spacing)
        Console.Write("Save as: ");
        string fileName = Console.ReadLine();
        if (fileName.ToLower() != "prompts.txt") // prompts.txt holds all the prompts for easy modification. As such, there's a check.
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry._getDate);
                    outputFile.WriteLine(entry._sortedPrompt);
                    outputFile.WriteLine(entry._saveInput);
                    outputFile.WriteLine(" ");
                }
            }
        }
        else
        {
            Console.WriteLine("You shouldn't do that! Saving as 'notprompts.txt'!"); // Uses an alternate name instead if using prompts.txt
            using (StreamWriter outputFile = new StreamWriter("notprompts.txt"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry._getDate);
                    outputFile.WriteLine(entry._sortedPrompt);
                    outputFile.WriteLine(entry._saveInput);
                    outputFile.WriteLine(" ");
                }
            }
        }
    }

    public void DisplayEntries()
    {
        // This function is almost identical to the save function, but puts it on the Console instead of a file
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._getDate);
            Console.WriteLine(entry._sortedPrompt);
            Console.WriteLine(entry._saveInput);
            Console.WriteLine("");
        }
    }
}