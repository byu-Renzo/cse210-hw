using System;
using System.Diagnostics;

public class BlogResource : LearningResource
{
  private string _author;

  public BlogResource(string title, string description, string url, string creatingDate, string author) : base(title, description, url, creatingDate)
  {
    _author = author;
  }

  public override void DisplayDetails()
  {
    Console.WriteLine($"Title: {GetTitle()} ({_author})");
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
    Console.WriteLine("Opening the blog on browser...");
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
    return $"BlogResource||{GetTitle()},{GetDescription()},{GetUrl()},{GetCreatingDate()},{_author}, {GetResume()}";
  }

}