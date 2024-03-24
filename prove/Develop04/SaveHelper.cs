public class SaveHelper
{
  public static void CreateFile(string currentDate)
  {
    string fileName = $"{currentDate}.txt";
    File.WriteAllText(fileName, "File created on " + currentDate);

  }

  public static void AppendLineToFile(string fileName, string lineToAdd)
  {
    using (StreamWriter writer = File.AppendText(fileName))
    {
      writer.WriteLine(lineToAdd);
    }
  }
}