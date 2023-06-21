namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// Yet another 'ConcreteProduct' class
public class GBPCurrency : ICurrency
{
  public string Name => "British Pound Sterling";
  public string Symbol => "£";
  public decimal ExchangeRate => 1.7m; // 1 GBP = 1.7 CAD

  public void DisplayInfo()
  {
    Console.WriteLine($"The currency of UK is {Name} ({Symbol})");
    Console.WriteLine($"The exchange rate is {ExchangeRate} CAD per GBP");
  }
}
