/*
Author: Renzo Rios Rugel
Date: 16/03/2024
Extra Credit:
- I Added the ability to load and read a JSON file.
- I Add the ability to filter the list of scriptures based on the user's level choice.
*/

class Program
{
    static void Main(string[] args)
    {
        // Get user input for the level of difficulty
        Console.WriteLine("Please enter a number (1. Basic, 2. Intermediate, 3. Advanced):");
        string userLevel = Console.ReadLine();

        // Read the JSON file and deserialize it into a list of ScriptureObjects
        string jsonString = File.ReadAllText("scriptures.json");
        List<ScriptureObject> scriptures = ScriptureObject.DeserializeJson(jsonString);

        // Filter the list of scriptures based on the user's choice
        string selectedLevel = "";
        switch (userLevel)
        {
            case "1":
                selectedLevel = "basic";
                break;
            case "2":
                selectedLevel = "intermediate";
                break;
            case "3":
                selectedLevel = "advanced";
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        List<ScriptureObject> filteredScriptures = ScriptureObject.FilterScriptures(scriptures, selectedLevel);

        // Select a random scripture from the filtered list
        Random random = new Random();
        int randomIndex = random.Next(filteredScriptures.Count);
        ScriptureObject randomScripture = filteredScriptures[randomIndex];

        // Create references
        Reference reference = new Reference(randomScripture.Book, randomScripture.Chapter, randomScripture.StartVerse, randomScripture.EndVerse);

        // Create scriptures
        Scripture scripture = new Scripture(reference, randomScripture.Scripture);

        string userInput = "";


        // Display the scripture and hide random words
        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompleteHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
    }
}

