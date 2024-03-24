public class ReflectionActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you did something really difficult.",
    "Think of a time when you were really proud of yourself.",
    "Think of a time when you helped someone else.",
    "Think of a time when you were really happy.",
    "Think of a time when you did something really different.",
    "Think of a time when you were really brave."
  };
  private List<string> _questions = new List<string>
  {
    "How did you feel during this experience?",
    "What did you learn about yourself?",
    "How can you use this experience in other aspects of your life?",
    "How did you show strength and resilience?",
    "How did you feel when it was complete?"
  };

  public ReflectionActivity() : base()
  {
    base._name = "Reflection Activity";
    base._description = "This activity will help you reflect on times in your life when you hace show strength and resilience. This help yoy recognize the power you have and how you can use it in other aspects of your life.";
  }

  public void Run()
  {
    Console.Clear();
    DisplayPrompt();

    Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
    Console.ReadLine();

    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
    Console.Write("You may begin in:  ");
    ShowCountdown(3);

    Console.Clear();
    DisplayQuestions(3);
  }

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(0, _prompts.Count);
    return _prompts[index];
  }

  public string GetRandomQuestion()
  {
    Random random = new Random();
    int index = random.Next(0, _questions.Count);
    return _questions[index];
  }

  public void DisplayPrompt()
  {
    string prompt = GetRandomPrompt();
    Console.WriteLine("\nConsider the following prompt:");
    Console.WriteLine($"\n--- {prompt} ---");
  }

  public void DisplayQuestions(int count)
  {
    for (int i = 0; i < count; i++)
    {
      string question = GetRandomQuestion();
      Console.WriteLine($"> {question}");
      ShowSpinner(_duration / count);
      Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Replicating this section proved to be quite challenging, requiring extensive searching across multiple forums.
    }
  }
}