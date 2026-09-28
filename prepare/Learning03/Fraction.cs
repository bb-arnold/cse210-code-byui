using System;

class Fraction
{
    Random random = new Random();

    //Attributes
    private int _top;
    private int _bottom;

    //Constructor Methods
    public Fraction()
    {
        SetTop(1);
        SetBottom(1);
    }
    public Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        SetBottom(1);
    }
    public Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    //Methods 
    // - Getters and setters
    public int GetTop ()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom ()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // - other methods
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }    

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top/_bottom;
        return decimalValue;
    }

    public string RandomFractionString()
    {
            SetTop(random.Next(0,31));
            SetBottom(random.Next(1,31));

            string fractionInfo = $"string: {GetFractionString()} Number: {GetDecimalValue()}";
            return fractionInfo;
    }
}