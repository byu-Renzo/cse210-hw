public abstract class LearningResource
{
  private string _title;
  private string _description;
  private string _url;
  private string _creatingDate;

  private string _resourceType;

  private string _resume;

  public LearningResource(string title, string description, string url, string creatingDate)
  {
    _title = title;
    _description = description;
    _url = url;
    _creatingDate = creatingDate;
  }

  public string GetResourceType()
  {
    return _resourceType;
  }

  public void SetResourceType(string resourceType)
  {
    _resourceType = resourceType;
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


  public string GetCreatingDate()
  {
    return _creatingDate;
  }

  public string GetResume()
  {
    return _resume;
  }

  public void SetResume(string resume)
  {
    _resume = resume;
  }

  public abstract void DisplayDetails();
  public abstract void Open();
  public abstract string GetStringRepresentation();
}