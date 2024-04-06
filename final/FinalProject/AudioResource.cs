public class AudioResource : LearningResource
{
  private int _duration;

  public AudioResource(string title, string description, string url, DateTime creatingDate, int duration) : base(title, description, url, creatingDate)
  {
    _duration = duration;
  }

  public override void DisplayDetails()
  {
    throw new NotImplementedException();
  }

  public override void Open()
  {
    throw new NotImplementedException();
  }

  public void Play()
  {
    throw new NotImplementedException();
  }

}