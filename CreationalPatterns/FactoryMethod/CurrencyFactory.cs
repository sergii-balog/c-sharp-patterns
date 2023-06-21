namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// The 'Creator' abstract class
public abstract class CurrencyFactory
{
  // The factory method that returns an ICurrency object
  public abstract ICurrency CreateCurrency();
}
