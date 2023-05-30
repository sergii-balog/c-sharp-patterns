namespace C_Sharp_Patterns.Observer.Events;

// An observer class that displays the price change on console
public class ConsoleDisplay
{
  // A method that matches the signature of the event handler delegate
  public void Display(object sender, PriceChangedEventArgs e)
  {
    // Display the new price on console
    Console.WriteLine($"The new BTC price is {e.NewPrice:C}");
  }
}

