namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// A 'ConcreteCreator' class
public class USACurrencyFactory : CurrencyFactory
{
  // Override the factory method to return a USDCurrency object
  public override ICurrency CreateCurrency()
  {
    return new USDCurrency();
  }
}
