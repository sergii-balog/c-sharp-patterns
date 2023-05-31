namespace C_Sharp_Patterns.TemplateMethod;

// A concrete subclass that implements cash on delivery payment
public class CashOnDeliveryOrder : OrderProcessor
{
  // Override the abstract step to process cash on delivery payment
  protected override void ProcessPayment()
  {
    Console.WriteLine("Printing receipt...");
    Console.WriteLine("Collecting money...");
  }

  // Override the abstract step to deliver product by hand
  protected override void DeliverProduct()
  {
    Console.WriteLine("Delivering product by hand...");
  }
}
