namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// A 'ConcreteProduct' class
public class USDCurrency : ICurrency
{
  public string Name => "United States Dollar";
  public string Symbol => "$";
  public decimal ExchangeRate => 1.30m; // 1 USD = 1.30 CAD

  public void DisplayInfo()
  {
    Console.WriteLine($"The currency of USA is {Name} ({Symbol})");
    Console.WriteLine($"The exchange rate is {ExchangeRate} CAD per USD");
  }
}
