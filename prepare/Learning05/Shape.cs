public abstract class Shape
{
    string _color = "";

    public string GetColor()
    {
        return _color;
    }

    protected void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}