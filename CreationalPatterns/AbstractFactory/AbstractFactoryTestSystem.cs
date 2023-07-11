namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

public class AbstractFactoryTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Abstract Factory pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a factory for European products
    IContinentFactory europeFactory = new EuropeFactory();
    ICurrency euro = europeFactory.CreateCurrency();
    ICountry france = europeFactory.CreateCountry();

    Console.WriteLine($"European currency: {euro.Name}, {euro.Symbol}");
    Console.WriteLine($"European country: {france.Name}, {france.Capital}");

    // Create a factory for Asian products
    IContinentFactory asiaFactory = new AsiaFactory();
    ICurrency yen = asiaFactory.CreateCurrency();
    ICountry japan = asiaFactory.CreateCountry();

    Console.WriteLine($"Asian currency: {yen.Name}, {yen.Symbol}");
    Console.WriteLine($"Asian country: {japan.Name}, {japan.Capital}");
  }
}
