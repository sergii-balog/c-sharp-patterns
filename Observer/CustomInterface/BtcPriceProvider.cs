namespace C_Sharp_Patterns.Observer.CustomInterface;

// A provider class that implements the provider interface
public class BtcPriceProvider : IBtcPriceProvider
{
    // A field that stores the current price
    private decimal _currentPrice;
    // A field that stores the current iteration
    private int _iterations = 0;

    // A field that stores a list of observers
    private List<IBtcPriceObserver> _observers;

    // A constructor that initializes the fields
    public BtcPriceProvider()
    {
        _currentPrice = 0;
        _observers = new List<IBtcPriceObserver>();
    }

    // A method that implements the registration logic
    public void RegisterObserver(IBtcPriceObserver observer)
    {
        // Add the observer to the list if not already present
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    // A method that implements the notification logic
    public void NotifyObservers(decimal newPrice)
    {
        // Loop through each observer in the list
        foreach (var observer in _observers)
        {
            // Call the observer's update method with the new price
            observer.Update(newPrice);
        }
    }

    // A method that fetches the current price from an API
    private decimal GetCurrentPrice()
    {
        // Some logic to call an API and get the current price
        // For simplicity, we use a random number here
        return new Random().Next(30000, 60000);
    }

    // A method that checks for price changes periodically
    public async Task CheckPriceAsync()
    {
        while (_iterations<3)
        {
            // Get the current price from the API
            var newPrice = GetCurrentPrice();

            // Compare with the previous price
            if (newPrice != _currentPrice)
            {
                // Update the current price
                _currentPrice = newPrice;

                // Notify the observers with the new price
                NotifyObservers(newPrice);
            }

            _iterations++;
            // Wait for some time before checking again
            await Task.Delay(1000);
        }
    }
}
