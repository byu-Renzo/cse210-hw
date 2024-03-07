using System;
public class Entry
{
  /*
#### Define class attributes ####
*/
  public string _date;
  public string _promptText;
  public string _entryText;

  public Entry(string date, string promptText, string entryText)
  {
    _date = date;
    _promptText = promptText;
    _entryText = entryText;
  }

  /*
  #### Define class behaviors ####
  */
  public void Display()
  {
    string formattedDate = DateTime.Parse(_date).ToString("MM/dd/yyyy");
    Console.WriteLine($"Date: {formattedDate} - Prompt: {_promptText}");
    Console.WriteLine($"{_entryText}");
  }

}