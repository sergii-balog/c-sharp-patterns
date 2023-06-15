namespace C_Sharp_Patterns.BehavioralPatterns.TemplateMethod;

// The abstract base class that defines the template method and common steps
public abstract class OrderProcessor
{
  // The template method that calls the steps in order
  public void ProcessOrder()
  {
    Console.WriteLine();
    Console.WriteLine("Your order is being processed....");
    Console.WriteLine();
    ValidateOrder();
    PrepareProduct();
    ProcessPayment();
    DeliverProduct();
  }

  // A common step that is the same for all subclasses
  protected void ValidateOrder()
  {
    Console.WriteLine("Validating order...");
  }

  // A common step that is the same for all subclasses
  protected void PrepareProduct()
  {
    Console.WriteLine("Preparing product...");
  }

  // An abstract step that subclasses must implement
  protected abstract void ProcessPayment();

  // An abstract step that subclasses must implement
  protected abstract void DeliverProduct();
}
