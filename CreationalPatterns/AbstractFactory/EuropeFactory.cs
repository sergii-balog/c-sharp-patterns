namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

// A concrete factory for European products
public class EuropeFactory : IContinentFactory
{
  // Create a European currency product
  public ICurrency CreateCurrency()
  {
    return new Euro();
  }

  // Create a European country product
  public ICountry CreateCountry()
  {
    return new France();
  }
}
