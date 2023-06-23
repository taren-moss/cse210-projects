public class ChecklistGoal : Goal
{
    private int _currentCount = 0;
    private int _targetCount = 0;
    private int _bonusPoints = 0;


    public ChecklistGoal(string title, string description, int points, int count1, int count2, int bonus, bool status = false)
    { // Big constructor for a big class object
        SetType("Checklist Goal");
        SetTitle(title);
        SetDescription(description);
        SetPoints(points);
        _currentCount = count1;
        _targetCount = count2;
        _bonusPoints = bonus;
        SetStatus(status);
    }

    public override int[] GetOtherData() // Overridden to return an array of integers. This allows multiple pieces of data in one function.
    {
        int[] returnData = new int[] {_currentCount, _targetCount, _bonusPoints};
        return returnData;
    }

    public override int CompleteGoal() // Overridden to account for X / Y completions
    {
        _currentCount += 1; // If you run this program you add 1 completion
        if (GetStatus())
        {
            return 0; // If already complete, give no points.
        }
        else
        {
            if (_currentCount >= _targetCount) 
            {
                SetStatus(true);
                return (GetPoints() + _bonusPoints); // No bonus message but points are accounted for.
            }
            else
            {
                return GetPoints();
            }
        }
    }

    public override void PrintGoal() // Overridden to account for X / Y completions
    {
        if (_currentCount >= _targetCount) // Completion can be equal to or higher than target
        {
            Console.Write("[X] ");
        }
        else // If lower, it's not complete
        {
            Console.Write("[ ] ");
        }

        Console.Write($"{GetTitle()} ");
        Console.Write($"({GetDescription()}) ");
        Console.Write($"-- Completed: {_currentCount}/{_targetCount}"); // Current progress / target progress
    }
}