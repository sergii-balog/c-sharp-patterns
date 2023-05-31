namespace C_Sharp_Patterns.Strategy;

public class BitcoinPaymentStrategy: IPaymentStrategy
{
  public void Pay(Order order)
  {
    // Process payment with bitcoin
    Console.WriteLine($"{order.Amount:C} paid with BTC");
  }
}
