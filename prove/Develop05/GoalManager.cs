
public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public string Start()
  {
    DisplayPlayerInfo();
    Console.WriteLine("\nMenu options: ");
    Console.WriteLine("   1. Create New Goal");
    Console.WriteLine("   2. List Goals");
    Console.WriteLine("   3. Save Goals");
    Console.WriteLine("   4. Load Goals");
    Console.WriteLine("   5. Record Event");
    Console.WriteLine("   6. Quit");
    Console.Write("Select a choice from menu: ");
    string choice = Console.ReadLine();
    Console.WriteLine();
    return choice;
  }

  public void DisplayPlayerInfo()
  {
    // ######################
    // #### Extra Credit ####
    // ######################
    string level = "";
    if (_score >= 0)
    {
      level = "Beginner";
    }
    if (_score >= 100)
    {
      level = "Intermediate";
    }
    if (_score >= 500)
    {
      level = "Advanced";
    }
    if (_score >= 1000)
    {
      level = "Expert";
    }

    Console.WriteLine($"You have {_score} points. Your level is {level}.");
  }

  public void ListGoalNames()
  {
    int i = 1;
    Console.WriteLine("The goals are: ");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{i}. {goal.GetName()}");
      i++;
    }
  }

  public void ListGoalDetails()
  {
    int i = 1;
    Console.WriteLine("The goals are: ");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine($"{i}. {goal.GetDetailsString()}");
      i++;
    }
  }

  public void CreateGoal()
  {
    Console.WriteLine("The types of Goals are: ");
    Console.WriteLine("   1. Simple Goal");
    Console.WriteLine("   2. Eternal Goal");
    Console.WriteLine("   3. ChecklistGoal");

    Console.Write("Which type of goal would you like to create? ");
    string goalType = Console.ReadLine();

    Console.Write("What is the name of your goal: ");
    string name = Console.ReadLine();
    Console.Write("What is the short description of it? ");
    string description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    string points = Console.ReadLine();

    if (goalType == "1")
    {
      SimpleGoal newSimpleGoal = new SimpleGoal(name, description, int.Parse(points));
      _goals.Add(newSimpleGoal);
    }
    else if (goalType == "2")
    {
      EternalGoal newEternalGoal = new EternalGoal(name, description, int.Parse(points));
      _goals.Add(newEternalGoal);
    }
    else if (goalType == "3")
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      int target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for accomplishing it that many times? ");
      int bonus = int.Parse(Console.ReadLine());

      ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, int.Parse(points), target, bonus);
      _goals.Add(newChecklistGoal);
    }
    else
    {
      Console.WriteLine("Invalid choice. Please try again.");
    }

  }

  public void RecordEvent()
  {
    ListGoalNames();
    Console.Write("Which Goal did you accomplish? ");
    int goalCompleted = int.Parse(Console.ReadLine());

    _goals[goalCompleted - 1].RecordEvent();

    int earnedPoints = _goals[goalCompleted - 1].GetPoints();

    // ######################
    // #### Extra Credit ####
    // ######################
    if (_score < 100 && _score + earnedPoints >= 100)
    {
      Console.WriteLine("You have reached the Intermediate level!");
    }
    if (_score < 500 && _score + earnedPoints >= 500)
    {
      Console.WriteLine("You have reached the Advanced level!");
    }
    if (_score < 1000 && _score + earnedPoints >= 1000)
    {
      Console.WriteLine("You have reached the Expert level!");
    }
    _score += earnedPoints;
    Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");

  }

  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(fileName))
    {
      writer.WriteLine($"{_score}");
      foreach (Goal goal in _goals)
      {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal life? ");
    string file = Console.ReadLine();
    string[] lines = File.ReadAllLines(file);

    _score = int.Parse(lines.First());

    string[] text = lines.Skip(1).ToArray();

    foreach (string line in text)
    {
      string[] parts = line.Split(":");

      string goalType = parts[0];

      string details = parts[1];

      string[] part = details.Split(",");

      if (goalType == "SimpleGoal")
      {
        SimpleGoal simplePart = new SimpleGoal(part[0], part[1], int.Parse(part[2]));

        if (part[3] == "True")
        {
          simplePart.RecordEvent();
        }

        _goals.Add(simplePart);

      }
      else if (goalType == "EternalGoal")
      {
        EternalGoal eternalPart = new EternalGoal(part[0], part[1], int.Parse(part[2]));

        _goals.Add(eternalPart);

      }
      else if (goalType == "ChecklistGoal")
      {
        ChecklistGoal checklistPart = new ChecklistGoal(part[0], part[1], int.Parse(part[2]), int.Parse(part[4]), int.Parse(part[3]));
        checklistPart.SetAmount(int.Parse(part[5]));

        _goals.Add(checklistPart);
      }
    }
  }
}