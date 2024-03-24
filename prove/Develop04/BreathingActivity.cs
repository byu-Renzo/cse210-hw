class BreathingActivity : Activity
{
  public BreathingActivity() : base()
  {
    base._name = "Breathing Activity";
    base._description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  public void Run()
  {
    int remainingDuration = base._duration;

    Console.Clear();
    while (remainingDuration > 0)
    {
      Console.Write("Breathe in...");
      ShowCountdown(5);
      remainingDuration -= 5;

      if (remainingDuration <= 0)
        break;

      Console.Write("Now breathe out...");
      ShowCountdown(6);
      Console.WriteLine("");
      remainingDuration -= 6;
    }
  }

}