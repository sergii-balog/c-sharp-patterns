namespace C_Sharp_Patterns.CreationalPatterns.Builder;

// Another concrete Builder for another representation
class NissanBuilder : IBuilder
{
  private readonly Car _car = new Car();

  public void BuildEngine()
  {
    _car.Add("Gasoline engine");
  }

  public void BuildWheels()
  {
    _car.Add("18-inch wheels");
  }

  public void BuildColor()
  {
    _car.Add("Red color");
  }

  public Car GetResult()
  {
    return _car;
  }
}
