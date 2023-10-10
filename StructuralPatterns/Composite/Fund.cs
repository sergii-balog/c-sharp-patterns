namespace C_Sharp_Patterns.StructuralPatterns.Composite;

// A fund is a complex asset that can contain other assets as its components
public class Fund : IAsset
{
  private readonly string _name;

  // A list of assets that belong to this fund
  private readonly List<IAsset> _assets;

  // Creates a new fund with the given name and an empty list of assets
  public Fund(string name)
  {
    _name = name;
    _assets = new List<IAsset>();
  }

  // Returns the name of the fund
  public string GetName()
  {
    return _name;
  }

  // Returns the value of the fund, which is the sum of the values of its components
  public decimal GetValue()
  {
    decimal value = 0;
    foreach (IAsset asset in _assets)
    {
      value += asset.GetValue();
    }
    return value;
  }

  // Adds a new asset to the fund
  public void Add(IAsset asset)
  {
    _assets.Add(asset);
  }

  // Removes an existing asset from the fund
  public void Remove(IAsset asset)
  {
    _assets.Remove(asset);
  }

  // Returns the list of assets that belong to this fund
  public List<IAsset> GetAssets()
  {
    return _assets;
  }
}
