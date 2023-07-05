namespace C_Sharp_Patterns.CreationalPatterns.Prototype;

// The concrete class that inherits from Vehicle
public class Car : Vehicle
{
  // A property specific to Car
  public int Doors { get; set; }

  // The Clone method that creates a shallow copy using MemberwiseClone
  public override object Clone()
  {
    return this.MemberwiseClone();
  }
  // ToString override
  public override string ToString()
  {
    return $"{base.ToString()} Doors: {Doors}";
  }
}
