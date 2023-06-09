public class ParentClass
{
    private string _testString = "";

    protected void SetString()
    {
        _testString = "testSuccess";
    }
    protected string GetString()
    {
        return _testString;
    }
}