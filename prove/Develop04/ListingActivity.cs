public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>
  {
    "When have you felt the Holy Ghost this month?",
    "What is something you are grateful for?",
    "What is something you have learned recently?",
    "What is something you have accomplished recently?",
    "What is something you are looking forward to?",
  };

  public ListingActivity() : base()
  {
    base._name = "Listing Activity";
    base._description = "This activity will help you reflect on the good things in your life by having you lost as many things as you can in a certain area.";
  }

  public void Run()
  {
    Console.Clear();
    Console.WriteLine("List as many response you can to the following prompt:");
    string prompt = GetRandomPrompt();
    Console.WriteLine($"\n--- {prompt} ---");
    Console.Write("\nYou may begin in: ");
    ShowCountdown(5);

    List<string> itemList = GetListFromUser();
    _count = itemList.Count;

    Console.WriteLine($"\nYou listed {_count} items.");
  }

  public string GetRandomPrompt()
  {
    Random randomPrompt = new Random();
    int i = randomPrompt.Next(0, _prompts.Count);
    return _prompts[i];
  }

  public List<string> GetListFromUser()
  {
    DateTime startTime = DateTime.Now;
    List<string> responses = new List<string>();
    DateTime endTime = startTime.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      responses.Add(Console.ReadLine());
    }
    return responses;
  }
}