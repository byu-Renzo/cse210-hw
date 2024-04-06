public class RepositoryResource : LearningResource
{
  private string _owner;

  public RepositoryResource(string title, string description, string url, DateTime creatingDate, string owner) : base(title, description, url, creatingDate)
  {
    _owner = owner;
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