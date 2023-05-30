namespace C_Sharp_Patterns.Observer.Events;

public class ObserverEventsTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Observer pattern as events");
    Console.WriteLine();

    // Create an instance of the provider class
    var monitor = new BtcPriceMonitor();

    // Create instances of the observer classes
    var display = new ConsoleDisplay();
    var logger = new FileLogger();

    // Subscribe to the event using += operator
    monitor.PriceChanged += display.Display;
    monitor.PriceChanged += logger.Log;

    // Start checking for price changes asynchronously
    await monitor.CheckPriceAsync();

    // Unsubscribe from the event using -= operator (optional)
    monitor.PriceChanged -= display.Display;
    monitor.PriceChanged -= logger.Log;
  }
}
