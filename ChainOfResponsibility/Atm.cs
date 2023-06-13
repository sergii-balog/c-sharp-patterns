namespace C_Sharp_Patterns.ChainOfResponsibility;

// The 'Client' class
public class Atm
{
  private readonly Handler _handler;

  public Atm()
  {
    // Setup Chain of Responsibility
    _handler = new FiftyDollarHandler();
    Handler handler2 = new TwentyDollarHandler();
    Handler handler3 = new TenDollarHandler();
    _handler.SetSuccessor(handler2);
    handler2.SetSuccessor(handler3);
  }

  public void Withdraw(int amount)
  {
    // Process the request
    _handler.HandleRequest(amount);
  }
}
