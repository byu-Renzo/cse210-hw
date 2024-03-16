public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = new List<Word>();
    string[] words = text.Split(' ');
    foreach (string word in words)
    {
      _words.Add(new Word(word));
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    for (int i = 0; i < numberToHide; i++)
    {
      Random rnd = new Random();
      int myRandomNumber;
      myRandomNumber = rnd.Next(0, _words.Count);
      while (_words[myRandomNumber].IsHidden() && !this.IsCompleteHidden())
      {
        myRandomNumber = rnd.Next(0, _words.Count);
      }
      _words[myRandomNumber].Hide();
    }
  }

  public string GetDisplayText()
  {
    string result = _reference.GetDisplayText() + "\n";
    foreach (Word word in _words)
    {
      result += word.GetDisplayText() + " ";
    }
    return result;
  }

  public bool IsCompleteHidden()
  {
    foreach (Word word in _words)
    {
      if (!word.IsHidden())
      {
        return false;
      }
    }
    return true;
  }
}