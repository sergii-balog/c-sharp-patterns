namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// Another 'ConcreteProduct' class
public class CADCurrency : ICurrency
{
  public string Name => "Canadian Dollar";
  public string Symbol => "C$";
  public decimal ExchangeRate => 0.75m; // 1 CAD = 0.75 USD

  public void DisplayInfo()
  {
    Console.WriteLine($"The currency of Canada is {Name} ({Symbol})");
    Console.WriteLine($"The exchange rate is {ExchangeRate} USD per CAD");
  }
}
