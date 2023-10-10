namespace C_Sharp_Patterns.StructuralPatterns.Composite;

// The component interface defines the common operations for all assets
public interface IAsset
{
  // Returns the name of the asset
  string GetName();

  // Returns the value of the asset
  decimal GetValue();

  // Adds a new asset to the portfolio (only applicable for funds)
  void Add(IAsset asset);

  // Removes an existing asset from the portfolio (only applicable for funds)
  void Remove(IAsset asset);
}
