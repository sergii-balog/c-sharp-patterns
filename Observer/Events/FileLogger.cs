namespace C_Sharp_Patterns.Observer.Events;

// An observer class that logs the price change to a file
public class FileLogger
{
  // A method that matches the signature of the event handler delegate
  public void Log(object sender, PriceChangedEventArgs e)
  {
    // Log the new price to a file
    File.AppendAllText("log.txt", $"The new BTC price is {e.NewPrice:C}\n");
  }
}
