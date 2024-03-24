public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  public Activity()
  {
  }

  public string GetName()
  {
    return _name;
  }

  public int GetDuration()
  {
    return _duration;
  }



  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine("");
    Console.WriteLine(_description);
    Console.WriteLine("");
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(3);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Well done!!");
    ShowSpinner(5);
    Console.WriteLine($"You have complete another {_duration} seconds of the {_name}.");
    ShowSpinner(5);
  }

  public void ShowSpinner(int seconds)
  {
    DateTime currentTime = DateTime.Now;
    DateTime targetTime = currentTime.AddSeconds(seconds);
    char[] spinner = { '|', '/', '-', '\\' };
    int index = 0;
    while (currentTime < targetTime)
    {
      Console.Write("\r" + spinner[index]);
      index = (index + 1) % spinner.Length;
      Thread.Sleep(100);
      currentTime = DateTime.Now;
    }
    Console.Write(" ");
  }

  public void ShowCountdown(int seconds)
  {
    DateTime currentTime = DateTime.Now;
    DateTime targetTime = currentTime.AddSeconds(seconds);
    while (currentTime < targetTime)
    {
      Console.Write(seconds);
      seconds--;
      Thread.Sleep(1000);
      currentTime = DateTime.Now;
      Console.Write("\b");
    }
    Console.Write(" ");
    Console.WriteLine("");
  }

}