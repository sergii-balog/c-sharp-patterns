namespace C_Sharp_Patterns.BehavioralPatterns.Observer.BuiltInInterface;

// A provider class that implements the IObservable<decimal> interface
public class BtcPriceProvider : IObservable<decimal>
{
    // A field that stores the current price
    private decimal _currentPrice;
    // A field that stores the current iteration
    private int _iterations = 0;

    // A field that stores a list of observers
    private List<IObserver<decimal>> observers;

    // A constructor that initializes the fields
    public BtcPriceProvider()
    {
        _currentPrice = 0;
        observers = new List<IObserver<decimal>>();
    }

    // A method that implements the subscription logic
    public IDisposable Subscribe(IObserver<decimal> observer)
    {
        // Add the observer to the list if not already present
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }

        // Return an IDisposable object that allows the observer to unsubscribe
        return new Unsubscriber(observers, observer);
    }

    // A nested class that implements the IDisposable interface
    private class Unsubscriber : IDisposable
    {
        // A field that stores a reference to the list of observers
        private List<IObserver<decimal>> _observers;

        // A field that stores a reference to the observer to unsubscribe
        private IObserver<decimal> _observer;

        // A constructor that initializes the fields
        public Unsubscriber(List<IObserver<decimal>> observers, IObserver<decimal> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        // A method that implements the unsubscription logic
        public void Dispose()
        {
            // Remove the observer from the list if still present
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }

    // A method that fetches the current price from an API
    private decimal GetCurrentPrice()
    {
        // Some logic to call an API and get the current price
        // For simplicity, we use a random number here
        return new Random().Next(30000, 60000);
    }

    // A method that checks for price changes periodically and notifies observers
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

                // Loop through each observer in the list
                foreach (var observer in observers)
                {
                    // Call the observer's OnNext method with the new price
                    observer.OnNext(newPrice);
                }
            }

            _iterations++;
            // Wait for some time before checking again
            await Task.Delay(1000);
        }
    }
}
