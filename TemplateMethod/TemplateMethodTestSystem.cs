namespace C_Sharp_Patterns.TemplateMethod;

public class TemplateMethodTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Template Method pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a credit card order and process it
    OrderProcessor creditCardOrder = new CreditCardOrder();
    creditCardOrder.ProcessOrder();

    // Create a PayPal order and process it
    OrderProcessor payPalOrder = new PayPalOrder();
    payPalOrder.ProcessOrder();

    // Create a cash on delivery order and process it
    OrderProcessor cashOnDeliveryOrder = new CashOnDeliveryOrder();
    cashOnDeliveryOrder.ProcessOrder();
  }
}
