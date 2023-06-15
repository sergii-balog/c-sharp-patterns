namespace C_Sharp_Patterns.BehavioralPatterns.Mediator;

// The abstract mediator class
public abstract class Mediator
{
  // The method for sending messages to colleagues
  public abstract void Send(string message, BtcExchange colleague);
}
