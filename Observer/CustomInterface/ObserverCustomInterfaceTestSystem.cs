namespace C_Sharp_Patterns.Observer.CustomInterface;

public class ObserverCustomInterfaceTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Observer pattern as custom interface");
    Console.WriteLine();

    // Create an instance of the provider class
    var provider = new BtcPriceProvider();

    // Create instances of the observer classes
    var display = new ConsoleDisplay();
    var logger = new FileLogger();

    // Register the observers using their interface methods
    provider.RegisterObserver(display);
    provider.RegisterObserver(logger);

    // Start checking for price changes asynchronously using their interface methods
    await provider.CheckPriceAsync();
  }
}
