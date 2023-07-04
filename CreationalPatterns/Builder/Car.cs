namespace C_Sharp_Patterns.CreationalPatterns.Builder;

// The Product class that represents the complex object
class Car
{
  readonly List<string> _parts = new List<string>();

  public void Add(string part)
  {
    _parts.Add(part);
  }

  public void Display()
  {
    Console.WriteLine("\nCar Parts -------");
    foreach (string part in _parts)
      Console.Write(part + " ");
    Console.WriteLine();
  }
}
