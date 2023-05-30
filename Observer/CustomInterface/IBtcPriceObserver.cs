namespace C_Sharp_Patterns.Observer.CustomInterface;

// An interface for observers
public interface IBtcPriceObserver
{
  // A method for handling notifications
  void Update(decimal newPrice);
}
