public class GrandchildClass : ChildClass
{
    public void RunTest()
    {
        SetString();
        SetInt();
        Console.WriteLine(GetString());
        Console.WriteLine(GetInt());
    }

    public int GetCountdown()
    {
        Console.WriteLine("This loops forever");
        Thread.Sleep(500);
        return GetCountdown();
    }
}