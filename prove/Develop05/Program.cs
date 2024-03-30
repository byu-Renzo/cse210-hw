/*
Author: Renzo Rios Rugel
Date: 29/03/2024
Extra Credit:
- I display level of player based on score points (Beginner, Intermediate, Advanced, Expert)
- I have added the ability to show when the user levels up based on the score points
*/

class Program
{
    static void Main(string[] args)
    {
        bool isRun = true;

        GoalManager goalManager = new GoalManager();

        while (isRun)
        {
            string choice = goalManager.Start();

            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            else if (choice == "2")
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                goalManager.SaveGoals();
            }
            else if (choice == "4")
            {
                goalManager.LoadGoals();
            }
            else if (choice == "5")
            {
                goalManager.RecordEvent();
            }
            else if (choice == "6")
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                isRun = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}