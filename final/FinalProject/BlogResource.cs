public class BlogResource : LearningResource
{
  private string _author;

  public BlogResource(string title, string description, string url, DateTime creatingDate, string author) : base(title, description, url, creatingDate)
  {
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