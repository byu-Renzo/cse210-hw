public class PaperResource : LearningResource
{
  private int _pages;
  private string _author;
  private string _type;

  public PaperResource(string title, string description, string url, DateTime creatingDate, int pages, string author, string type) : base(title, description, url, creatingDate)
  {
    _pages = pages;
    _author = author;
    _type = type;
  }

  public override void DisplayDetails()
  {
    throw new NotImplementedException();
  }

  public override void Open()
  {
    throw new NotImplementedException();
  }

}