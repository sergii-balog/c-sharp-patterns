namespace C_Sharp_Patterns.StructuralPatterns.Composite;

// A bond is a simple asset that has a name and a value
public class Bond : IAsset
{
  private readonly string _name;
  private readonly decimal _value;

  // Creates a new bond with the given name and value
  public Bond(string name, decimal value)
  {
    _name = name;
    _value = value;
  }

  // Returns the name of the bond
  public string GetName()
  {
    return _name;
  }

  // Returns the value of the bond
  public decimal GetValue()
  {
    return _value;
  }

  // Throws an exception, since bonds cannot contain other assets
  public void Add(IAsset asset)
  {
    throw new InvalidOperationException("Cannot add asset to bond");
  }

  // Throws an exception, since bonds cannot contain other assets
  public void Remove(IAsset asset)
  {
    throw new InvalidOperationException("Cannot remove asset from bond");
  }
}
