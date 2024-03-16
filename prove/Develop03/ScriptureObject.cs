using System.Text.Json;

public class ScriptureObject
{
  public string Book { get; set; }
  public int Chapter { get; set; }
  public int StartVerse { get; set; }
  public int EndVerse { get; set; }
  public string Scripture { get; set; }
  public string Difficulty { get; set; }


  public static List<ScriptureObject> DeserializeJson(string jsonString)
  {
    List<ScriptureObject> scriptures = new List<ScriptureObject>();

    JsonDocument document = JsonDocument.Parse(jsonString);
    foreach (JsonElement element in document.RootElement.EnumerateArray())
    {
      ScriptureObject scripture = new ScriptureObject();
      scripture.Book = element.GetProperty("book").GetString();
      scripture.Chapter = element.GetProperty("chapter").GetInt32();
      scripture.StartVerse = element.GetProperty("startVerse").GetInt32();
      scripture.EndVerse = element.GetProperty("endVerse").GetInt32();
      scripture.Scripture = element.GetProperty("scripture").GetString();
      scripture.Difficulty = element.GetProperty("difficulty").GetString();

      scriptures.Add(scripture);
    }

    return scriptures;
  }

  public static List<ScriptureObject> FilterScriptures(List<ScriptureObject> scriptures, string level)
  {
    List<ScriptureObject> filteredList = new List<ScriptureObject>();
    foreach (ScriptureObject scripture in scriptures)
    {
      if (scripture.Difficulty == level)
      {
        filteredList.Add(scripture);
      }
    }
    return filteredList;
  }
}