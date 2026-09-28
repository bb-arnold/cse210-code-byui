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
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
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
            _top = random.Next(0,31);
            _bottom = random.Next(1,31);
            
            SetBottom(_bottom);
            SetTop(_top);

            string fractionInfo = $"string: {GetFractionString()} Number: {GetDecimalValue()}";
            return fractionInfo;
    }
}