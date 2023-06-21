namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// Another 'ConcreteCreator' class
public class CanadaCurrencyFactory : CurrencyFactory
{
  // Override the factory method to return a CADCurrency object
  public override ICurrency CreateCurrency()
  {
    return new CADCurrency();
  }
}
