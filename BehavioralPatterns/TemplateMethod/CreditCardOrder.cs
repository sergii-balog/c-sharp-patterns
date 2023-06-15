namespace C_Sharp_Patterns.BehavioralPatterns.TemplateMethod;

// A concrete subclass that implements credit card payment
public class CreditCardOrder : OrderProcessor
{
  // Override the abstract step to process credit card payment
  protected override void ProcessPayment()
  {
    Console.WriteLine("Validating card number...");
    Console.WriteLine("Charging amount...");
  }

  // Override the abstract step to deliver product by courier
  protected override void DeliverProduct()
  {
    Console.WriteLine("Delivering product by courier...");
  }
}
