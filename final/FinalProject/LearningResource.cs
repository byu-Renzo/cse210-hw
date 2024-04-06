public abstract class LearningResource
{
  private string _title;
  private string _description;
  private string _url;
  private DateTime _creatingDate;

  public LearningResource(string title, string description, string url, DateTime creatingDate)
  {
    _title = title;
    _description = description;
    _url = url;
    _creatingDate = creatingDate;
  }

  public string GetTitle()
  {
    return _title;
  }

  public string GetDescription()
  {
    return _description;
  }

  public string GetUrl()
  {
    return _url;
  }


  public DateTime GetCreatingDate()
  {
    return _creatingDate;
  }

  public abstract void DisplayDetails();
  public abstract void Open();
}