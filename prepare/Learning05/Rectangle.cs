public class Rectangle : Shape
{
    private double _sideOne = 0;
    private double _sideTwo = 0;

    public Rectangle(string color, double sideOne, double sideTwo)
    {
        SetColor(color);
        _sideOne = sideOne;
        _sideTwo = sideTwo;
    }

    public override double GetArea()
    {
        return _sideOne * _sideTwo;
    }
}