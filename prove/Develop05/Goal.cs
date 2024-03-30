public abstract class Goal
{
  private string _shortName;
  private string _description;
  private int _points;

  public Goal(string name, string description, int points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  public string GetName()
  {
    return _shortName;
  }

  public string GetDescription()
  {
    return _description;
  }

  public int GetPoints()
  {
    return _points;
  }

  public void SetPoints(int points)
  {
    _points = points;
  }

  public abstract void RecordEvent();
  public abstract bool IsComplete();
  public virtual string GetDetailsString()
  {
    string completedSymbol = IsComplete() ? "[X]" : "[ ]";
    
    return $"{completedSymbol} {_shortName} ({_description})";
  }
  public abstract string GetStringRepresentation();

}