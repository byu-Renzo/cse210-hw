public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base(name, description, points) { }

  public override void RecordEvent()
  {
    Console.WriteLine($"Recorded event for EternalGoal: {base.GetName()}");
  }
  public override bool IsComplete()
  {
    return false;
  }

  public override string GetStringRepresentation()
  {
    return $"EternalGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()}";
  }
}