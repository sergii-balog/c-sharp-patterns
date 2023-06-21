namespace C_Sharp_Patterns.CreationalPatterns.FactoryMethod;

// The 'Product' interface
public interface ICurrency
{
  string Name { get; }
  string Symbol { get; }
  decimal ExchangeRate { get; }
  void DisplayInfo();
}
