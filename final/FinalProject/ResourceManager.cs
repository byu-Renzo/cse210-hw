public class ResourceManager
{
  private List<LearningResource> _resources;

  public ResourceManager()
  {
    _resources = new List<LearningResource>();
  }

  public void AddResource(LearningResource resource)
  {
    _resources.Add(resource);
  }

  public void RemoveResource(LearningResource resource)
  {
    _resources.Remove(resource);
  }

  public void DisplayAllResources()
  {
    foreach (LearningResource resource in _resources)
    {
      Console.WriteLine(resource.GetTitle());
    }
  }

  public void SaveResources(string fileName)
  {
    throw new NotImplementedException();
  }

  public void LoadResources(string fileName)
  {
    throw new NotImplementedException();
  }

}