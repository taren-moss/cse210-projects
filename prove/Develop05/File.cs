public class File
{
    List<Goal> _goalsList = new List<Goal>();
    int _points = 0;

    public File()
    {
        _goalsList = new List<Goal>();
    }
    public File(string filename)
    {
        LoadFile(filename);
    }

    public int GetPoints()
    {
        return _points;
    }

    public int RecordGoal(int index) // Accepts an integer to use as an index for the Goals List
    {
        if (index < _goalsList.Count() & index >= 0) // Error protection
        {
            int pointGain = _goalsList[index].CompleteGoal(); // Completes the goal and grabs point value at the same time
            _points += pointGain; // Adds the point value to the total
            return pointGain; // returns the point value for printing
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("ERROR: Invalid Index"); // If the check fails, it means index is out of range, and an error message is sent.
            return 0; // Invalid indexes are worth 0 points.
        }
    }

    public void SaveGoal(Goal goal) // Just adds a goal to the file.
    {
        _goalsList.Add(goal);
    }

    public void SaveFile(string filename) // Saves goals list with a special format in a .txt file.
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_points);
                foreach (Goal goal in _goalsList)
                {
                    if (goal.GetType() != "Checklist Goal") // Checklists needs more data
                    {
                        outputFile.WriteLine($"{goal.GetType()}|{goal.GetTitle()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}");
                    }
                    else
                    {
                        int[] otherData = goal.GetOtherData(); // 3 pieces of data in one variable. Called with otherData[0] through otherData[2]
                        outputFile.WriteLine($"{goal.GetType()}|{goal.GetTitle()}|{goal.GetDescription()}|{goal.GetPoints()}|{otherData[0]}|{otherData[1]}|{otherData[2]}|{goal.GetStatus()}");
                    }
                }
            }
    }

    public void LoadFile(string filename) // Loading was harder than expected
    {
        List<Goal> loadedList = new List<Goal>();
        int lineCount = 0; // Keeps track of which line it's on

        string[] loadData = System.IO.File.ReadAllLines(filename);
        foreach (string line in loadData)
        {
            if (lineCount == 0) // First line is points, do something different for it
            {
                _points = int.Parse(line);
            }
            else
            {
                string[] lineData = line.Split("|"); // Data is split with "|"

                string loadedTitle = lineData[1];
                string loadedDescription = lineData[2];
                int loadedPointValue = int.Parse(lineData[3]);
                int loadedCount1 = 0;
                int loadedCount2 = 0;
                int loadedBonus = 0;
                bool loadedStatus = false; // Placegolder value

                if (lineData.Count() > 5) // Checklist data is much longer
                {
                    loadedCount1 = int.Parse(lineData[4]);
                    loadedCount2 = int.Parse(lineData[5]);
                    loadedBonus = int.Parse(lineData[6]);
                    loadedStatus = bool.Parse(lineData[7]); // completion value is at index 7 for checklist goals
                }
                else // Anything that isn't bigger than 5 is not a checklist goal, and completion value is at index 4
                {
                    loadedStatus = bool.Parse(lineData[4]);
                }

                if (lineData[0] == "Simple Goal")
                {
                    loadedList.Add(new SimpleGoal(loadedTitle, loadedDescription, loadedPointValue, loadedStatus)); // Constructor power
                }
                else if (lineData[0] == "Eternal Goal")
                {
                    loadedList.Add(new EternalGoal(loadedTitle, loadedDescription, loadedPointValue, loadedStatus)); // New through constructors
                }
                else if (lineData[0] == "Checklist Goal")
                {
                    loadedList.Add(new ChecklistGoal(loadedTitle, loadedDescription, loadedPointValue, loadedCount1, loadedCount2, loadedBonus, loadedStatus));
                } // The checklist constructor gets really long
                else
                {
                    Console.WriteLine("ERROR"); // Just in case something fails somehow
                }
            }
            lineCount += 1; // Increment by 1 each time
        }

        _goalsList = loadedList; // Once the whole loaded list is done, set the goal list to the loaded list
    }

    public void ListGoals() // Used for goal list when using the Record Event option
    {
        int count = 0;
        foreach (Goal goal in _goalsList)
        {
            count += 1;
            Console.WriteLine($"{count}. {goal.GetTitle()}"); // Prints goal data in a different format from printed goals.
        }
    }

    public void PrintFile() // Simply goes through each goal and tells each goal to use PrintGoal()
    {
        foreach (Goal goal in _goalsList)
        {
            goal.PrintGoal();
            Console.WriteLine();
        }
    }
}