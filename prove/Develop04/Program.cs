/*
Author: Renzo Rios Rugel
Date: 23/03/2024
Extra Credit:
- I Added the ability save the user's activities to a file on txt format.
- I Replicated the same indentation for each menu item to make it easier to read.
*/

class Program
{
    static void Main(string[] args)
    {
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        SaveHelper.CreateFile(currentDate);
        SaveHelper.AppendLineToFile(currentDate + ".txt", "");
        Console.Clear();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            // Note: I try to use the same indentation for each menu item to make it easier to read.
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflection activity");
            Console.WriteLine("   3. Start listening activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    SaveHelper.AppendLineToFile(currentDate + ".txt", $"You have complete another {breathing.GetDuration()} seconds of the {breathing.GetName()}.");
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.DisplayStartingMessage();
                    reflection.Run();
                    reflection.DisplayEndingMessage();
                    SaveHelper.AppendLineToFile(currentDate + ".txt", $"You have complete another {reflection.GetDuration()} seconds of the {reflection.GetName()}.");
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    SaveHelper.AppendLineToFile(currentDate + ".txt", $"You have complete another {listing.GetDuration()} seconds of the {listing.GetName()}.");
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    break;
            }
        }
    }
}