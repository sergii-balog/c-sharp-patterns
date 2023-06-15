namespace C_Sharp_Patterns.BehavioralPatterns.ChainOfResponsibility;

// The 'ConcreteHandler1' class for 10 dollar bills
public class TenDollarHandler : Handler
{
  public override void HandleRequest(int amount)
  {
    if (amount >= 10)
    {
      int number = amount / 10;
      int remaining = amount % 10;
      Console.WriteLine($"Dispensing {number} 10$ bill(s)");
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
