namespace C_Sharp_Patterns.Mediator;

public class MediatorTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Mediator pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create an exchange rate service instance
    var exchangeRateService = new ExchangeRateService();

    // Create some subscriber instances
    var binance = new Subscriber("Binance");
    var coinbase = new Subscriber("Coinbase");
    var kraken = new Subscriber("Kraken");

    // Register them with the exchange rate service
    exchangeRateService.Register(binance);
    exchangeRateService.Register(coinbase);
    exchangeRateService.Register(kraken);

    // Send some messages
    binance.Send("The current BTC/USD rate is 50,000");
    Console.WriteLine();
    coinbase.Send("The current BTC/EUR rate is 42,000");
    Console.WriteLine();
    kraken.Send("The current BTC/GBP rate is 36,000");
  }
}
