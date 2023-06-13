namespace C_Sharp_Patterns.ChainOfResponsibility;

// The 'ConcreteHandler2' class for 20 dollar bills
public class TwentyDollarHandler : Handler
{
  public override void HandleRequest(int amount)
  {
    if (amount >= 20)
    {
      int number = amount / 20;
      int remaining = amount % 20;
      Console.WriteLine($"Dispensing {number} 20$ bill(s)");
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
