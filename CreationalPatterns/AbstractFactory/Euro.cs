namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

// A concrete product for European currency
public class Euro : ICurrency
{
  public string Name => "Euro";
  public string Symbol => "€";
}
