public class ChildClass : ParentClass
{
    private int testInt = 0;

    protected void SetInt()
    {
        testInt = 9;
    }
    protected int GetInt()
    {
        return testInt;
    }
}