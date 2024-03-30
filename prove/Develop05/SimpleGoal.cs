public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    _isComplete = false;
  }

  public override void RecordEvent()
  {
    _isComplete = true;
    Console.WriteLine($"Recorded event for SimpleGoal: {base.GetName()}");
  }
  public override bool IsComplete()
  {
    return _isComplete;
  }
  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{_isComplete}";
  }
}