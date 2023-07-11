namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

// A concrete product for Asian currency
public class Yen : ICurrency
{
  public string Name => "Yen";
  public string Symbol => "¥";
}
