/*
Author: Renzo Rios Rugel
Date: 07/03/2024
Extra Credit:
- I Added the ability to load and save entries from and to a .csv file.
- I Controlled error handling for file names that do not end with .txt or .csv.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{promptText}");
                Console.Write("> ");
                string entryText = Console.ReadLine();
                if (entryText == "")
                {
                    Console.WriteLine("The entry text cannot be empty. Please try again.");
                    continue;
                }
                DateTime date = DateTime.Now;
                Entry entry = new Entry(date.ToString(), promptText, entryText);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                if (fileName.EndsWith(".txt"))
                {
                    journal.LoadFromFile(fileName);
                }
                else if (fileName.EndsWith(".csv"))
                {
                    journal.LoadFromCSV(fileName);
                }
                else
                {
                    Console.WriteLine("The file should be a .txt or .csv file. Please try again.");
                    continue;
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                if (fileName.EndsWith(".txt"))
                {
                    journal.SaveToFile(fileName);
                }
                else if (fileName.EndsWith(".csv"))
                {
                    journal.SaveToCSV(fileName);
                }
                else
                {
                    Console.WriteLine("The file should be a .txt or .csv file. Please try again.");
                    continue;
                }
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}