namespace C_Sharp_Patterns.BehavioralPatterns.Observer.BuiltInInterface;

// An observer class that implements the IObserver<decimal> interface and displays the price change on console
public class ConsoleDisplay : IObserver<decimal>
{
  // A field that stores a reference to an IDisposable object for unsubscription
  private IDisposable _unsubscriber;

  // A method that implements the subscription logic
  public void Subscribe(IObservable<decimal> provider)
  {
    // Call the provider's Subscribe method and store the returned IDisposable object
    _unsubscriber = provider.Subscribe(this);
  }

  // A method that implements the unsubscription logic
  public void Unsubscribe()
  {
    // Call the IDisposable object's Dispose method to unsubscribe from notifications
    _unsubscriber.Dispose();
  }

  // A method that implements the notification logic for new data
  public void OnNext(decimal newPrice)
  {
    // Display the new price on console
    Console.WriteLine($"The new BTC price is {newPrice:C}");
  }

  // A method that implements the notification logic for errors (not used in this example)
  public void OnError(Exception error)
  {
    // Do nothing in this example
  }

  // A method that implements the notification logic for completion (not used in this example)
  public void OnCompleted()
  {
    // Do nothing in this example
  }
}
