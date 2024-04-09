using System;
using System.Diagnostics;

public class RepositoryResource : LearningResource
{
  private string _owner;

  public RepositoryResource(string title, string description, string url, string creatingDate, string owner) : base(title, description, url, creatingDate)
  {
    _owner = owner;
  }

  public override void DisplayDetails()
  {
    Console.WriteLine($"Title: {GetTitle()} ({_owner})");
    Console.WriteLine($"Description: {GetDescription()}");
    Console.WriteLine($"Creating Date: {GetCreatingDate()}");
    Console.WriteLine();

    if (GetResume() != null)
    {
      Console.WriteLine($"Resume: {GetResume()}");
    }
  }

  public override void Open()
  {
    Console.WriteLine("Opening the Github repository on browser...");
    Console.WriteLine(GetUrl());

    ProcessStartInfo psi = new ProcessStartInfo
    {
      FileName = GetUrl(),
      UseShellExecute = true
    };
    Process.Start(psi);
  }

  public override string GetStringRepresentation()
  {
    return $"RepositoryResource||{GetTitle()},{GetDescription()},{GetUrl()},{GetCreatingDate()},{_owner}, {GetResume()}";
  }


}