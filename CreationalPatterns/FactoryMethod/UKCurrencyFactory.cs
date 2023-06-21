namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// Yet another 'ConcreteCreator' class
public class UKCurrencyFactory : CurrencyFactory
{
  // Override the factory method to return a GBPCurrency object
  public override ICurrency CreateCurrency()
  {
    return new GBPCurrency();
  }
}
