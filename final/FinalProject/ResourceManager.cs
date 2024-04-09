public class ResourceManager
{
  private List<LearningResource> _resources;

  public ResourceManager()
  {
    _resources = new List<LearningResource>();
  }

  public List<LearningResource> GetResources()
  {
    return _resources;
  }

  public void AddResource(LearningResource resource)
  {
    _resources.Add(resource);
  }

  public void ListResourceNames()
  {
    int i = 1;
    Console.WriteLine("The resources are: ");
    foreach (LearningResource resource in _resources)
    {
      Console.WriteLine($"{i}. {resource.GetResourceType()} - {resource.GetTitle()}");
      i++;
    }
  }

  public void RemoveResource(LearningResource resource)
  {
    _resources.Remove(resource);
  }

  public void DisplayAllResources()
  {
    if (_resources.Count == 0)
    {
      Console.WriteLine("There are no resources to display.");
      Console.WriteLine();
      return;
    }

    Console.WriteLine("Type          |Title                       | Description                              |Date        | Url");
    Console.WriteLine("--------------|----------------------------|------------------------------------------|------------|----------------------------------");

    foreach (LearningResource resource in _resources)
    {
      Console.WriteLine($"{resource.GetResourceType(),-14}|{resource.GetTitle(),-28}| {resource.GetDescription(),-41}| {resource.GetCreatingDate():yyyy-MM-dd} | {resource.GetUrl()}");
    }
    Console.WriteLine();
  }

  public void SaveResources(string fileName)
  {

    using (StreamWriter writer = new StreamWriter(fileName))
    {
      foreach (LearningResource resource in _resources)
      {
        writer.WriteLine(resource.GetStringRepresentation());
      }
    }
  }

  public void LoadResources(string fileName)
  {
    string[] lines = File.ReadAllLines(fileName);
    string[] text = lines.ToArray();

    foreach (string line in text)
    {
      string[] parts = line.Split("||");
      string resourceType = parts[0];
      Console.WriteLine(resourceType);
      string details = parts[1];
      string[] part = details.Split(",");

      if (resourceType == "BookResource")
      {
        BookResource bookPart = new BookResource(part[0], part[1], part[2], part[3], int.Parse(part[4]), part[5]);
        bookPart.SetResourceType("Book");
        bookPart.SetResume(part[6]);
        _resources.Add(bookPart);
      }
      else if (resourceType == "AudioResource")
      {
        AudioResource audioPart = new AudioResource(part[0], part[1], part[2], part[3], int.Parse(part[4]));
        audioPart.SetResourceType("Audio");
        audioPart.SetResume(part[5]);
        _resources.Add(audioPart);
      }
      else if (resourceType == "VideoResource")
      {
        VideoResource videoPart = new VideoResource(part[0], part[1], part[2], part[3], int.Parse(part[4]));
        videoPart.SetResourceType("Video");
        videoPart.SetResume(part[5]);
        _resources.Add(videoPart);
      }
      else if (resourceType == "PaperResource")
      {
        PaperResource paperPart = new PaperResource(part[0], part[1], part[2], part[3], int.Parse(part[4]), part[5], part[6]);
        paperPart.SetResourceType("Paper");
        paperPart.SetResume(part[7]);
        _resources.Add(paperPart);
      }
      else if (resourceType == "RepositoryResource")
      {
        RepositoryResource repositoryPart = new RepositoryResource(part[0], part[1], part[2], part[3], part[4]);
        repositoryPart.SetResourceType("Github");
        repositoryPart.SetResume(part[5]);
        _resources.Add(repositoryPart);
      }
      else if (resourceType == "BlogResource")
      {
        BlogResource blogPart = new BlogResource(part[0], part[1], part[2], part[3], part[4]);
        blogPart.SetResourceType("Blog");
        blogPart.SetResume(part[5]);
        _resources.Add(blogPart);
      }
      else
      {
        Console.WriteLine("Invalid resource type.");
      }
    }
  }
}