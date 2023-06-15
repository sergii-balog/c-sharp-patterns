namespace C_Sharp_Patterns.BehavioralPatterns.Observer.Events;

// A provider class that monitors the price of BTC
public class BtcPriceMonitor
{
// An event that uses the event handler delegate
  public event PriceChangedEventHandler PriceChanged;

  // A field that stores the current price
  private decimal _currentPrice;
  // A field that stores the current iteration
  private int _iterations = 0;

  // A method that fetches the current price from an API
  private decimal GetCurrentPrice()
  {
    // Some logic to call an API and get the current price
    // For simplicity, we use a random number here
    return new Random().Next(30000, 60000);
  }

  // A method that raises the event
  private void OnPriceChanged(PriceChangedEventArgs e)
  {
    // Check if there are any subscribers
    if (PriceChanged != null)
    {
      // Call each subscriber's method
      PriceChanged(this, e);
    }
  }

  // A method that checks for price changes periodically
  public async Task CheckPriceAsync()
  {
    while (_iterations < 3)
    {
      // Get the current price from the API
      var newPrice = GetCurrentPrice();

      // Compare with the previous price
      if (newPrice != _currentPrice)
      {
        // Update the current price
        _currentPrice = newPrice;

        // Create a custom EventArgs object with the new price
        var args = new PriceChangedEventArgs(newPrice);

        // Raise the event
        OnPriceChanged(args);
      }

      _iterations++;
      // Wait for some time before checking again
      await Task.Delay(1000);
    }
  }
}
