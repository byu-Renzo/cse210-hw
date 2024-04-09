using System;
using System.Diagnostics;
public class PaperResource : LearningResource
{
  private int _pages;
  private string _author;
  private string _type;

  public PaperResource(string title, string description, string url, string creatingDate, int pages, string author, string type) : base(title, description, url, creatingDate)
  {
    _pages = pages;
    _author = author;
    _type = type;
  }

  public override void DisplayDetails()
  {
    Console.WriteLine($"Title: {GetTitle()} ({_author})");
    Console.WriteLine($"Description: {GetDescription()}");
    Console.WriteLine($"Creating Date: {GetCreatingDate()} / Pages: {_pages} / Type: {_type}");
    Console.WriteLine();

    if (GetResume() != null)
    {
      Console.WriteLine($"Resume: {GetResume()}");
    }
  }

  public override void Open()
  {
    Console.WriteLine("Opening the paper on browser...");
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
    return $"PaperResource||{GetTitle()},{GetDescription()},{GetUrl()},{GetCreatingDate()},{_pages},{_author},{_type}, {GetResume()}";
  }

}