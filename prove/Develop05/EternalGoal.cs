public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points, bool status = false)
    {
        SetType("Eternal Goal");
        SetTitle(title);
        SetDescription(description);
        SetPoints(points);
        SetStatus(status);
    }

    public override int CompleteGoal()
    {
        return GetPoints();
    }
}