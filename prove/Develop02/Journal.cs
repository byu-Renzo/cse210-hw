
public class Journal
{
  /*
  #### Define class attributes ####
  */
  public List<Entry> _entries = new List<Entry>();


  /*
  #### Define class behaviors ####
  */
  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("No entries to display.");
      return;
    }
    foreach (Entry entry in _entries)
    {
      entry.Display();
      Console.WriteLine();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter writer = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine(entry._date);
        writer.WriteLine(entry._promptText);
        writer.WriteLine(entry._entryText);
        writer.WriteLine();
      }
    }
  }

  public void SaveToCSV(string file)
  {
    using (StreamWriter writer = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
      }
    }
  }

  

  public void LoadFromCSV(string file)
  {
    _entries.Clear();

    using (StreamReader reader = new StreamReader(file))
    {
      while (!reader.EndOfStream)
      {
        string line = reader.ReadLine();
        string[] values = line.Split(',');

        Entry entry = new Entry(values[0], values[1], values[2]);

        _entries.Add(entry);
      }
    }
  }

  public void LoadFromFile(string file)
  {
    _entries.Clear();

    using (StreamReader reader = new StreamReader(file))
    {
      while (!reader.EndOfStream)
      {
        string dateText = reader.ReadLine();
        string promptText = reader.ReadLine();
        string entryText = reader.ReadLine();

        DateTime date = DateTime.Parse(dateText);

        Entry entry = new Entry(date.ToString(), promptText, entryText);

        _entries.Add(entry);
      }
    }
  }
}