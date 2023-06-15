namespace C_Sharp_Patterns.BehavioralPatterns.Observer.CustomInterface;

// An interface for providers
public interface IBtcPriceProvider
{
  // A method for registering observers
  void RegisterObserver(IBtcPriceObserver observer);

  // A method for notifying observers
  void NotifyObservers(decimal newPrice);
}
