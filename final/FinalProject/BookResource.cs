public class BookResource : LearningResource
{
  private int _pages;
  private string _author;

  public BookResource(string title, string description, string url, DateTime creatingDate, int pages, string author) : base(title, description, url, creatingDate)
  {
    _pages = pages;
    _author = author;
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