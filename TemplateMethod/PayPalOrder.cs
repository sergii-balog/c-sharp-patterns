namespace C_Sharp_Patterns.TemplateMethod;

// A concrete subclass that implements PayPal payment
public class PayPalOrder : OrderProcessor
{
  // Override the abstract step to process PayPal payment
  protected override void ProcessPayment()
  {
    Console.WriteLine("Redirecting to PayPal website...");
    Console.WriteLine("Confirming payment...");
  }

  // Override the abstract step to deliver product by email
  protected override void DeliverProduct()
  {
    Console.WriteLine("Delivering product by email...");
  }
}
