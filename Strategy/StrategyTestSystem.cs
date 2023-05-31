namespace C_Sharp_Patterns.Strategy;

public class StrategyTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Strategy pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    var order = new Order
    {
      Amount = 100m
    };
    order.ProcessPayment(); // Pays with credit card by default

    order.SetPaymentStrategy(new PayPalPaymentStrategy());
    order.ProcessPayment(); // Pays with PayPal

    order.SetPaymentStrategy(new BitcoinPaymentStrategy());
    order.ProcessPayment(); // Pays with Bitcoin
  }
}
