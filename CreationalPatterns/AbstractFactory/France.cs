namespace C_Sharp_Patterns.CreationalPatterns.AbstractFactory;

// A concrete product for European country
public class France : ICountry
{
  public string Name => "France";
  public string Capital => "Paris";
}
