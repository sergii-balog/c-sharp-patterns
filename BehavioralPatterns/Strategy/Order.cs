namespace C_Sharp_Patterns.BehavioralPatterns.Strategy;

public class Order
{
  // field to store the order amount
  public decimal Amount { get; set; }

  // field to store the payment strategy
  private IPaymentStrategy _paymentStrategy;

  public Order(IPaymentStrategy paymentStrategy)
  {
    _paymentStrategy = paymentStrategy;
  }
  // Pays with credit card by default
  public Order() : this(new CreditCardPaymentStrategy())
  {
  }
  // Change the payment strategy
  public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
  {
    _paymentStrategy = paymentStrategy;
  }
  // Process the payment
  public void ProcessPayment()
  {
    _paymentStrategy.Pay(this);
  }
}
