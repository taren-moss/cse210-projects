public class Fraction
{
    private int _numerator = 0;
    private int _denominator = 0;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int number)
    {
        _numerator = number;
        _denominator = 1;
    }

    public Fraction(int number1, int number2)
    {
        _numerator = number1;
        _denominator = number2;
    }

    public string GetFractionString()
    {
        string returnValue = $"{_numerator}/{_denominator}";
        return returnValue;
    }

    public double GetDecimalValue()
    {
        double returnValue = (double)_numerator / (double)_denominator;
        return returnValue;
    }
}