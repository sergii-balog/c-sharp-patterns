namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

// An interface for continent factories
public interface IContinentFactory
{
  // A method for creating currency products
  ICurrency CreateCurrency();
  // A method for creating country products
  ICountry CreateCountry();
}
