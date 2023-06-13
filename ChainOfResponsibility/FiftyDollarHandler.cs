namespace C_Sharp_Patterns.ChainOfResponsibility;

// The 'ConcreteHandler3' class for 50 dollar bills
public class FiftyDollarHandler : Handler
{
  public override void HandleRequest(int amount)
  {
    if (amount >= 50)
    {
      int number = amount / 50;
      int remaining = amount % 50;
      Console.WriteLine($"Dispensing {number} 50$ bill(s)");
      if (remaining != 0)
      {
        Successor?.HandleRequest(remaining);
      }
    }
    else
    {
      Successor?.HandleRequest(amount);
    }
  }
}
