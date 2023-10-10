namespace C_Sharp_Patterns.StructuralPatterns.Composite;

// A stock is a simple asset that has a name and a value
public class Stock : IAsset
{
  private readonly string _name;
  private readonly decimal _value;

  // Creates a new stock with the given name and value
  public Stock(string name, decimal value)
  {
    _name = name;
    _value = value;
  }

  // Returns the name of the stock
  public string GetName()
  {
    return _name;
  }

  // Returns the value of the stock
  public decimal GetValue()
  {
    return _value;
  }

  // Throws an exception, since stocks cannot contain other assets
  public void Add(IAsset asset)
  {
    throw new InvalidOperationException("Cannot add asset to stock");
  }

  // Throws an exception, since stocks cannot contain other assets
  public void Remove(IAsset asset)
  {
    throw new InvalidOperationException("Cannot remove asset from stock");
  }
}
