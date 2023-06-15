namespace C_Sharp_Patterns.BehavioralPatterns.Observer.CustomInterface;

// An observer class that implements the observer interface and logs the price change to a file
public class FileLogger : IBtcPriceObserver
{
  // A method that implements the update logic
  public void Update(decimal newPrice)
  {
    // Log the new price to a file
    File.AppendAllText("log.txt", $"The new BTC price is {newPrice:C}\n");
  }
}
