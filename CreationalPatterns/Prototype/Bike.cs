namespace C_Sharp_Patterns.CreationalPatterns.Prototype;

// Another concrete class that inherits from Vehicle
public class Bike : Vehicle
{
  // A property specific to Bike
  public string Type { get; set; }

  // The Clone method that creates a shallow copy using MemberwiseClone
  public override object Clone()
  {
    return this.MemberwiseClone();
  }
  // ToString override
  public override string ToString()
  {
    return $"{base.ToString()} Type: {Type}";
  }
}
