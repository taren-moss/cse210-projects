public abstract class Goal
{
    private string _goalType = "type";
    private string _goalTitle = "";
    private string _goalDescription = "";
    private bool _goalComplete = false;
    private int _pointValue = 0;


    public new string GetType()
    {
        return _goalType;
    }
    public string GetTitle()
    {
        return _goalTitle;
    }
    public string GetDescription()
    {
        return _goalDescription;
    }
    public bool GetStatus()
    {
        return _goalComplete;
    }
    public int GetPoints()
    {
        return _pointValue;
    }

    public virtual int[] GetOtherData() // I needed to make this getter for bonus point and completion count data from checklist goals.
    {
        return new int[] {}; // This value is unused by non-checklist goals. Empty array because it needs a default return value.
    }


    protected void SetType(string type)
    {
        _goalType = type;
    }
    protected void SetTitle(string title)
    {
        _goalTitle = title;
    }
    protected void SetDescription(string description)
    {
        _goalDescription = description;
    }
    protected void SetStatus(bool input)
    {
        _goalComplete = input;
    }
    protected void SetPoints(int points)
    {
        _pointValue = points;
    }


    public virtual void PrintGoal() // Virtual method/function
    {
        if (_goalComplete)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }

        Console.Write($"{_goalTitle} ");
        Console.Write($"({_goalDescription}) ");
    }
    public virtual int CompleteGoal() // This method sets the goal to complete and returns the point value
    {
        if (_goalComplete == false) // Does stuff if goal is not complete
        {
            _goalComplete = true;
            return _pointValue;
        }
        else
        {
            return 0; // Just does nothing is already complete
        }
    }
}