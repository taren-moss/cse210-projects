public class GrandchildClass : ChildClass
{
    public void RunTest()
    {
        SetString();
        SetInt();
        Console.WriteLine(GetString());
        Console.WriteLine(GetInt());
    }
}