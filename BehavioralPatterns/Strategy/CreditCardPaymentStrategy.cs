namespace C_Sharp_Patterns.BehavioralPatterns.Strategy;

public class CreditCardPaymentStrategy : IPaymentStrategy
{
  public void Pay(Order order)
  {
    // Process payment with credit card
    Console.WriteLine($"{order.Amount:C} paid with Credit Card");
  }
}
