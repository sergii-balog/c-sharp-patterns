namespace C_Sharp_Patterns.Observer.BuiltInInterface;

public class ObserverBuiltInInterfaceTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Observer pattern as built in interface");
    Console.WriteLine();

    // Create an instance of the provider class
    var provider = new BtcPriceProvider();

    // Create instances of the observer classes
    var display = new ConsoleDisplay();
    var logger = new FileLogger();

    // Subscribe to the provider using their interface methods
    display.Subscribe(provider);
    logger.Subscribe(provider);

    // Start checking for price changes asynchronously using their interface methods
    await provider.CheckPriceAsync();

    // Unsubscribe from the provider using their interface methods (optional)
    display.Unsubscribe();
    logger.Unsubscribe();
  }
}
