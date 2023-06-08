namespace C_Sharp_Patterns.Mediator;

// A concrete colleague class
public class Subscriber : BtcExchange
{
  // A constructor that takes a name as a parameter and calls the base constructor
  public Subscriber(string name) : base(name) { }

  // A method for receiving messages from the mediator
  public override void Receive(string message)
  {
    Console.WriteLine($"{Name} received: {message}");
  }
}
