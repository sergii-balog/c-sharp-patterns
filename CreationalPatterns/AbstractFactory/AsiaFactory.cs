namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

// A concrete factory for Asian products
public class AsiaFactory : IContinentFactory
{
  // Create an Asian currency product
  public ICurrency CreateCurrency()
  {
    return new Yen();
  }

  // Create an Asian country product
  public ICountry CreateCountry()
  {
    return new Japan();
  }
}
