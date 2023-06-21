namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

public class FactoryMethodTestSystem : ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Factory Method pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a CurrencyFactory object based on the country name
    CurrencyFactory factory = GetCurrencyFactory("Canada");

    // Use the factory method to create an ICurrency object
    ICurrency currency = factory.CreateCurrency();

    // Use the ICurrency object
    currency.DisplayInfo();
  }

  // A helper method that returns a CurrencyFactory object based on the country name
  CurrencyFactory GetCurrencyFactory(string country)
  {
    switch (country)
    {
      case "USA":
        return new USACurrencyFactory();
      case "Canada":
        return new CanadaCurrencyFactory();
      case "UK":
        return new UKCurrencyFactory();
      default:
        throw new ArgumentException("Invalid country");
    }
  }
}
