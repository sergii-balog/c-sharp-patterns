namespace C_Sharp_Patterns.BehavioralPatterns.Strategy;

public class PayPalPaymentStrategy: IPaymentStrategy
{
  public void Pay(Order order)
  {
    // Process payment with paypal
    Console.WriteLine($"{order.Amount:C} paid with PayPal");
  }
}
