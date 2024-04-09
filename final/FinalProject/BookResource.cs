using System;
using System.Diagnostics;

public class BookResource : LearningResource
{
  private int _pages;
  private string _author;

  public BookResource(string title, string description, string url, string creatingDate, int pages, string author) : base(title, description, url, creatingDate)
  {
    _pages = pages;
    _author = author;
  }

  public override void DisplayDetails()
  {
    Console.WriteLine($"Title: {GetTitle()} ({_author})");
    Console.WriteLine($"Description: {GetDescription()}");
    Console.WriteLine($"Creating Date: {GetCreatingDate()} - Pages: {_pages}");
    Console.WriteLine();

    if (GetResume() != null)
    {
      Console.WriteLine($"Resume: {GetResume()}");
    }
  }

  public override void Open()
  {
    Console.WriteLine("Opening the book on browser...");
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
    return $"BookResource||{GetTitle()},{GetDescription()},{GetUrl()},{GetCreatingDate()},{_pages},{_author}, {GetResume()}";
  }
}