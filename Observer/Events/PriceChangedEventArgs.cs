namespace C_Sharp_Patterns.Observer.Events;

// A custom class that contains the new price
public class PriceChangedEventArgs
{
  public decimal NewPrice { get; }

  public PriceChangedEventArgs(decimal newPrice)
  {
    NewPrice = newPrice;
  }
}

// An event handler delegate that uses the custom class
public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);
