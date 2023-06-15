namespace C_Sharp_Patterns.BehavioralPatterns.Observer.CustomInterface;

// An observer class that implements the observer interface and displays the price change on console
public class ConsoleDisplay : IBtcPriceObserver
{
  // A method that implements the update logic
  public void Update(decimal newPrice)
  {
    // Display the new price on console
    Console.WriteLine($"The new BTC price is {newPrice:C}");
  }
}
