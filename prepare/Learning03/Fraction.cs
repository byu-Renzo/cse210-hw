class Fraction
{
  // ### ATTRIBUTES ###
  private int _top;
  private int _bottom;


  // ### CONSTRUCTORS ###
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

  // ### GETTERS & SETTERS ###
  public int GetTop()
  {
    return _top;
  }

  public void SetTop(int top)
  {
    _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public void SetBottom(int bottom)
  {
    _bottom = bottom;
  }


  // ### METHODS ###
  public string GetFractionString()
  {
    string text = $"{_top}/{_bottom}";
    return text;
  }

  public double GetDecimalValue()
  {
    return (double)_top / (double)_bottom;
  }

}