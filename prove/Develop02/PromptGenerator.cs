public class PromptGenerator
{
  /*
#### Define class attributes ####
*/
  List<string> _prompts = new List<string>{
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
      "What was the most memorable part of my day?",
      "What was the most beautiful thing I saw today?",
      "What was the most difficult thing I had to deal with today?",
      "What was the most delicious thing I ate today?",
  };

  /*
  #### Define class behaviors ####
  */
  public string GetRandomPrompt()
  {
    Random random = new Random();
    int randomIndex = random.Next(0, _prompts.Count);
    return _prompts[randomIndex];
  }
}