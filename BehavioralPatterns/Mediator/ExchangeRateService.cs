namespace C_Sharp_Patterns.BehavioralPatterns.Mediator;

// The concrete mediator class
public class ExchangeRateService : Mediator
{
  // A dictionary of registered colleagues
  private readonly Dictionary<string, BtcExchange> _subscribers = new Dictionary<string, BtcExchange>();

  // A method for registering colleagues
  public void Register(BtcExchange subscriber)
  {
    if (!_subscribers.ContainsValue(subscriber))
    {
      _subscribers[subscriber.Name] = subscriber;
    }
    subscriber.ExchangeRateService = this;
  }

  // A method for sending messages to colleagues
  public override void Send(string message, BtcExchange subscriber)
  {
    if (_subscribers.ContainsValue(subscriber))
    {
      // Send the message to all colleagues except the sender
      foreach (var s in _subscribers.Values)
      {
        if (s != subscriber)
        {
          s.Receive(message);
        }
      }
    }
  }
}
