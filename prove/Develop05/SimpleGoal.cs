public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        SetType("");
        SetTitle("");
        SetDescription("");
        SetPoints(0);
    }
    public SimpleGoal(string title, string description, int points, bool status = false)
    {
        SetType("Simple Goal");
        SetTitle(title);
        SetDescription(description);
        SetPoints(points);
        SetStatus(status);
    }
}