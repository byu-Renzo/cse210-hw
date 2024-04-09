using System;
using System.Diagnostics;

public class VideoResource : LearningResource
{
  private int _duration;

  public VideoResource(string title, string description, string url, string creatingDate, int duration) : base(title, description, url, creatingDate)
  {
    _duration = duration;
  }

  public override void DisplayDetails()
  {
    Console.WriteLine($"Title: {GetTitle()} ({_duration} seconds)");
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
    Console.WriteLine("Opening the video on browser...");
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
    return $"VideoResource||{GetTitle()},{GetDescription()},{GetUrl()},{GetCreatingDate()},{_duration}, {GetResume()}";
  }
}