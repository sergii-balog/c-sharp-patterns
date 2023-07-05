namespace C_Sharp_Patterns.CreationalPatterns.Prototype;

// The abstract class that implements ICloneable
public abstract class Vehicle : ICloneable
{
  public string Make { get; set; }
  public string Model { get; set; }
  public string Color { get; set; }
  public decimal Price { get; set; }

  // The Clone method that returns a copy of the current object
  public abstract object Clone();
  // ToString override
  public override string ToString()
  {
    return $"Make: {Make} Model: {Model} Color: {Color} Price: ${Price}";
  }
}
