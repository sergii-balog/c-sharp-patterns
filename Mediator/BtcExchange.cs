namespace C_Sharp_Patterns.Mediator;

// The abstract colleague class
public abstract class BtcExchange
{
  // A property for getting or setting the mediator
  public Mediator ExchangeRateService { get; set; }

  // A property for getting the colleague name
  public string Name { get; }

  // A constructor that takes a name as a parameter
  public BtcExchange(string name)
  {
    Name = name;
  }

  // A method for sending messages to the mediator
  public void Send(string message)
  {
    ExchangeRateService.Send(message, this);
  }

  // An abstract method for receiving messages from the mediator
  public abstract void Receive(string message);
}
